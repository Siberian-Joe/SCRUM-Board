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

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text.Equals(""))
                ((TextBox)sender).Text = "Username";
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
                string connetionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=ScrumDB.mdb";
                OleDbConnection dbConnection = new OleDbConnection(connetionString);

                dbConnection.Open();
                OleDbCommand dbCommand = dbConnection.CreateCommand();
                dbCommand.CommandType = System.Data.CommandType.TableDirect;
                dbCommand.CommandText = "SELECT * FROM Пользователи WHERE [Имя пользователя] = '" + username + "' AND Пароль = '" + password + "'";
                //dbCommand.Parameters.Add("@username", OleDbType.VarChar).Value = username;
                //dbCommand.Parameters.Add("@password", OleDbType.VarChar).Value = password;

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

                //Console.WriteLine(dbReader["Имя пользователя"]);
                //Console.WriteLine(dbReader["Пароль"]);

                //while (dbReader.Read())
                //{
                //    //Console.WriteLine(dbReader["Имя пользователя"]);
                //    //Console.WriteLine(dbReader["Пароль"]);
                //}
                dbConnection.Close();
            }
            catch  (OleDbException ex)
            {
                MessageBox.Show("Ошибка подключения к базе данных!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void signUpButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Sign Up");
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
