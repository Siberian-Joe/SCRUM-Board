using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ScrumBoardNewDesign
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        OleDbConnection dbConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=ScrumDB.mdb");
        bool flag = false;
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text.Equals("Username"))
                ((TextBox)sender).Clear();
        }

        private void registrationFullNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text.Equals("Full Name"))
                ((TextBox)sender).Clear();
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text.Equals(""))
                ((TextBox)sender).Text = "Username";
        }

        private void registrationFullNameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text.Equals(""))
                ((TextBox)sender).Text = "Full Name";
        }

        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (((PasswordBox)sender).Password.Equals("Password"))
                ((PasswordBox)sender).Clear();
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((PasswordBox)sender).Password.Equals(""))
                ((PasswordBox)sender).Password = "Password";
        }

        private void signInButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Password;

            try
            {
                dbConnection.Open();
                OleDbCommand dbCommand = dbConnection.CreateCommand();
                dbCommand.CommandType = System.Data.CommandType.TableDirect;
                dbCommand.CommandText = "SELECT * FROM Пользователи WHERE [Имя пользователя] = '" + username + "' AND Пароль = '" + password + "'";

                OleDbDataReader dbReader = dbCommand.ExecuteReader();

                if (dbReader.HasRows)
                {
                    User mainUser = null;
                    while (dbReader.Read())
                    {
                        mainUser = new User(dbReader["Имя пользователя"].ToString(), dbReader["ФИО"].ToString(), (bool)dbReader["Менеджер"]);
                    }
                    dbConnection.Close();
                    new MainWindow(mainUser).Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Неверно введены данные!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);

                dbConnection.Close();
            }
            catch  (OleDbException ex)
            {
                MessageBox.Show("Ошибка подключения к базе данных!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void signUpButton_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "Sign Up";
            authorizationWindow.Visibility = Visibility.Collapsed;
            registrationWindow.Visibility = Visibility.Visible;
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void continueButton_Click(object sender, RoutedEventArgs e)
        {
            if (registrationFirstPasswordTextBox.Password != registrationSecondPasswordTextBox.Password)
                MessageBox.Show("Пароли не совпадают!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                try
                {
                    dbConnection.Open();
                    OleDbCommand dbCommand = dbConnection.CreateCommand();
                    dbCommand.CommandType = System.Data.CommandType.TableDirect;
                    dbCommand.CommandText = "SELECT * FROM Пользователи WHERE [Имя пользователя] = '" + registrationUsernameTextBox.Text + "'";

                    OleDbDataReader dbReader = dbCommand.ExecuteReader();

                    if (dbReader.HasRows)
                        flag = true;

                    dbConnection.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Ошибка подключения к базе данных!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                if (!flag)
                {
                    try
                    {
                        dbConnection.Open();
                        OleDbCommand dbCommand = new OleDbCommand("INSERT INTO Пользователи (ФИО, [Имя пользователя], Пароль) VALUES (" + "'" + registrationFullNameTextBox.Text + "'" + "," + "'" + registrationUsernameTextBox.Text + "'" + "," + "'" + registrationFirstPasswordTextBox.Password + "'" + ")", dbConnection);

                        dbCommand.ExecuteNonQuery();

                        dbConnection.Close();

                        flag = false;

                        textBlock.Text = "Sign In";
                        registrationWindow.Visibility = Visibility.Collapsed;
                        authorizationWindow.Visibility = Visibility.Visible;
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("Ошибка подключения к базе данных!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином уже зарегистрирован!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "Sign In";
            registrationWindow.Visibility = Visibility.Collapsed;
            authorizationWindow.Visibility = Visibility.Visible;
        }
    }
}
