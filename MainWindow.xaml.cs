using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ScrumBoardNewDesign
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static public User mainUser;
        string connetionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=ScrumDB.mdb";
        OleDbConnection dbConnection;
        List<User> users = new List<User>();
        List<string> columns = new List<string>();
        List<StackPanel> stackPanels = new List<StackPanel>();
        List<EditableTask> editableTasks = new List<EditableTask>();

        static public bool shiftIsPressed;

        public MainWindow(User mainUser)
        {
            InitializeComponent();
            MainWindow.mainUser = mainUser;



            //mainGrid.RowDefinitions.Add(new RowDefinition());
            //Grid grid = new Grid() { Width = 150, Height = 32 };
            //Border border = new Border() { Background = Brushes.White, Opacity =  0.5, CornerRadius = new CornerRadius(10)};

            //TextBlock textBlock = new TextBlock() { HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment =  VerticalAlignment.Center };

            //grid.Children.Add(border);
            //grid.Children.Add(textBlock);

            //textBlock.Text = users[0].fullName;
            //Grid.SetRow(grid, 1);

            //mainGrid.Children.Add(grid);

            readDB();
            fillFullNameColumn();
            fillColumns();
            fillTasks();
        }
        void readDB()
        {
            try
            {
                dbConnection = new OleDbConnection(connetionString);

                dbConnection.Open();
                OleDbCommand dbCommand = dbConnection.CreateCommand();
                dbCommand.CommandType = System.Data.CommandType.TableDirect;
                dbCommand.CommandText = "Пользователи";

                OleDbDataReader dbReader = dbCommand.ExecuteReader();

                while (dbReader.Read())
                    users.Add(new User(dbReader["Имя пользователя"].ToString(), dbReader["ФИО"].ToString(), (bool)dbReader["Менеджер"]));

                dbConnection.Close();
                dbConnection.Open();

                dbCommand.CommandText = "Столбцы";
                dbReader = dbCommand.ExecuteReader();

                while (dbReader.Read())
                    columns.Add(dbReader["Заголовок"].ToString());

                dbConnection.Close();
                dbConnection.Open();

                dbCommand.CommandText = "Задачи";

                dbReader = dbCommand.ExecuteReader();

                while (dbReader.Read())
                {
                    editableTasks.Add(new EditableTask(dbReader["Заголовок"].ToString(), dbReader["Описание"].ToString(), Convert.ToInt32(dbReader["Код столбца"].ToString()), Convert.ToInt32(dbReader["Код пользователя"].ToString())));
                }

                dbConnection.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Ошибка подключения к базе данных!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                dbConnection.Close();
            }
        }
        void fillFullNameColumn()
        {
            Grid gridEmpty = new Grid() { MinWidth = 150, MinHeight = 32, Margin = new Thickness(2)};
            Border borderEmpty = new Border() { Background = Brushes.White, Opacity = 0.5, CornerRadius = new CornerRadius(10) };
            gridEmpty.Children.Add(borderEmpty);
            mainGrid.Children.Add(gridEmpty);
            Grid.SetRow(gridEmpty, 0);

            for (int i = 0; i < users.Count; i++)
            {
                mainGrid.RowDefinitions.Add(new RowDefinition());
                Grid grid = new Grid() { MinWidth = 150, MinHeight = 32, Margin = new Thickness(2), VerticalAlignment = VerticalAlignment.Stretch};
                Border border = new Border() { Background = Brushes.White, Opacity = 0.5, CornerRadius = new CornerRadius(10)};

                TextBlock textBlock = new TextBlock() { HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center, FontFamily = new FontFamily("Helvetica"), FontWeight = FontWeights.Light };

                grid.Children.Add(border);
                grid.Children.Add(textBlock);

                textBlock.Text = users[i].fullName;
                Grid.SetRow(grid, i + 1);

                mainGrid.Children.Add(grid);
            }
        }

        void fillColumns()
        {
            for(int i = 0; i < columns.Count; i++)
            {
                mainGrid.ColumnDefinitions.Add(new ColumnDefinition());
                Grid gridTitle = new Grid() { Width = 150, Height = 32, Margin = new Thickness(2) };
                Border borderTitle = new Border() { Background = Brushes.White, Opacity = 0.5, CornerRadius = new CornerRadius(10) };

                TextBlock textBlock = new TextBlock() { HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center, FontFamily = new FontFamily("Helvetica"), FontWeight = FontWeights.Light };

                gridTitle.Children.Add(borderTitle);
                gridTitle.Children.Add(textBlock);

                textBlock.Text = columns[i];
                Grid.SetColumn(gridTitle, i + 1);

                mainGrid.Children.Add(gridTitle);

                for(int j = 0; j < users.Count; j++)
                {
                    
                    if (i == 0)
                    {
                        Grid grid = new Grid() { AllowDrop = true, HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Stretch, MinWidth = 150, MinHeight = (34 * users.Count), Margin = new Thickness(0, 1, 0, 1) };
                        StackPanel stackPanel = new StackPanel();
                        
                        Border border = new Border() { Background = Brushes.White, Opacity = 0.5, CornerRadius = new CornerRadius(10)};
                        grid.Drop += StackPanel_Drop;
                        stackPanels.Add(stackPanel);

                        grid.Children.Add(border);
                        grid.Children.Add(stackPanel);

                        Grid.SetColumn(grid, i + 1);
                        Grid.SetRow(grid, j + 1);

                        Grid.SetRowSpan(grid, users.Count);

                        mainGrid.Children.Add(grid);
                        break;
                    }
                    else
                    {
                        Grid grid = new Grid() { AllowDrop = true, HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Stretch, MinWidth = 150, MinHeight = 32, Margin = new Thickness(0, 1, 0, 2) };
                        StackPanel stackPanel = new StackPanel();
                        Border border = new Border() { Background = Brushes.White, Opacity = 0.5, CornerRadius = new CornerRadius(10) };

                        grid.Drop += StackPanel_Drop;

                        stackPanels.Add(stackPanel);

                        grid.Children.Add(border);
                        grid.Children.Add(stackPanel);

                        Grid.SetColumn(grid, i + 1);
                        Grid.SetRow(grid, j + 1);

                        mainGrid.Children.Add(grid);
                    }
                    

                }
            }
        }

        void fillTasks()
        {
            //try
            //{
            //    dbConnection.Open();
            //    OleDbCommand dbCommand = dbConnection.CreateCommand();
            //    dbCommand.CommandType = System.Data.CommandType.TableDirect;
            //    dbCommand.CommandText = "Задачи";

            //    OleDbDataReader dbReader = dbCommand.ExecuteReader();

            //    //while (dbReader.Read())
            //    //{
            //    //    if(dbReader["Код пользователя"].ToString().Equals(""))
            //    //        stackPanels[0].Children.Add(new EditableTask(dbReader["Заголовок"].ToString(), dbReader["Описание"].ToString()));
            //    //    else
            //    //        stackPanels[Convert.ToInt32(dbReader["Код пользователя"].ToString()) + users.Count * (Convert.ToInt32(dbReader["Код столбца"].ToString()) - 2)].Children.Add(new EditableTask(dbReader["Заголовок"].ToString(), dbReader["Описание"].ToString()));
            //    //}

            //    editableTasks.Add(new EditableTask(dbReader["Заголовок"].ToString(), dbReader["Описание"].ToString(), Convert.ToInt32(dbReader["Код столбца"].ToString()), Convert.ToInt32(dbReader["Код пользователя"].ToString())));

            //    dbConnection.Close();
            //}
            //catch (OleDbException ex)
            //{
            //    MessageBox.Show("Ошибка подключения к базе данных!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            //    dbConnection.Close();
            //}

            for(int i = 0; i < editableTasks.Count; i++)
            {
                Console.WriteLine(editableTasks[i].row + " " + editableTasks[i].column);
                if(editableTasks[i].row + users.Count * (editableTasks[i].column - 2) <  0)
                    stackPanels[0].Children.Add(editableTasks[i]);
                else
                    stackPanels[editableTasks[i].row + users.Count * (editableTasks[i].column - 2)].Children.Add(editableTasks[i]);
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addTaskButton_Click(object sender, RoutedEventArgs e)
        {
            stackPanels[0].Children.Add(new EditableTask());
        }

        private void refreshTaskButton_Click(object sender, RoutedEventArgs e)
        {
            mainGrid.Children.Clear();
            mainGrid.ColumnDefinitions.Clear();
            mainGrid.RowDefinitions.Clear();
            mainGrid.RowDefinitions.Add(new RowDefinition());
            mainGrid.ColumnDefinitions.Add(new ColumnDefinition());
            users.Clear();
            columns.Clear();
            stackPanels.Clear();
            editableTasks.Clear();

            readDB();
            fillFullNameColumn();
            fillColumns();
            fillTasks();
        }
        private void saveTaskButton_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(() => 
            {
                try
                {
                    dbConnection.Open();

                    loadingBorder.Visibility = Visibility.Visible;
                    OleDbCommand dbCommand = new OleDbCommand("DELETE * FROM [Столбцы]", dbConnection);
                    dbCommand.ExecuteNonQuery();

                    dbConnection.Close();

                    for (int i = 0; i < columns.Count; i++)
                    {
                        dbConnection.Open();
                        dbCommand = new OleDbCommand("INSERT INTO [Столбцы] VALUES (" + (i + 1) + ",'" + columns[i] + "')", dbConnection);
                        dbCommand.ExecuteNonQuery();
                        dbConnection.Close();
                    }

                    dbConnection.Open();

                    dbCommand = new OleDbCommand("DELETE * FROM [Задачи]", dbConnection);
                    dbCommand.ExecuteNonQuery();

                    dbConnection.Close();

                    for (int i = 0; i < editableTasks.Count; i++)
                    {
                        dbConnection.Open();
                        dbCommand = new OleDbCommand("INSERT INTO [Задачи] VALUES (" + editableTasks[i].column + ", " + editableTasks[i].row + ", '" + editableTasks[i].title + "', '" + editableTasks[i].info + "')", dbConnection);
                        dbCommand.ExecuteNonQuery();
                        dbConnection.Close();
                    }

                    //

                    //dbCommand.CommandText = "DELETE * FROM [Копия Задачи]";

                    //dbReader = dbCommand.ExecuteReader();

                    //while (dbReader.Read())
                    //    users.Add(new User(dbReader["Имя пользователя"].ToString(), dbReader["ФИО"].ToString(), (bool)dbReader["Менеджер"]));

                    //dbConnection.Close();
                    //dbConnection.Open();

                    //dbCommand.CommandText = "Столбцы";
                    //dbReader = dbCommand.ExecuteReader();

                    //while (dbReader.Read())
                    //    columns.Add(dbReader["Заголовок"].ToString());

                    dbConnection.Close();
                    loadingBorder.Visibility = Visibility.Collapsed;
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Ошибка подключения к базе данных!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    loadingBorder.Visibility = Visibility.Collapsed;
                    dbConnection.Close();
                }
                
            });     
        }
        private void StackPanel_Drop(object sender, DragEventArgs e)
        {
            if (mainUser.canEdit)
            {
                EditableTask editableTask = (EditableTask)e.Data.GetData(typeof(EditableTask));

                Console.WriteLine(editableTask.title + " " + editableTask.info);

                if (Grid.GetRow((Grid)sender) + users.Count * (Grid.GetColumn((Grid)sender) - 2) < 0)
                {
                    if (editableTask.row + users.Count * (editableTask.column - 2) < 0)
                        stackPanels[0].Children.Remove(editableTask);
                    else
                        stackPanels[editableTask.row + users.Count * (editableTask.column - 2)].Children.Remove(editableTask);
                    editableTask.row = Grid.GetRow((Grid)sender);
                    editableTask.column = Grid.GetColumn((Grid)sender);
                    stackPanels[0].Children.Add(editableTask);
                }
                    
                else
                {
                    if(editableTask.row + users.Count * (editableTask.column - 2) < 0)
                        stackPanels[0].Children.Remove(editableTask);
                    else
                        stackPanels[editableTask.row + users.Count * (editableTask.column - 2)].Children.Remove(editableTask);
                    editableTask.row = Grid.GetRow((Grid)sender);
                    editableTask.column = Grid.GetColumn((Grid)sender);
                    stackPanels[Grid.GetRow((Grid)sender) + users.Count * (Grid.GetColumn((Grid)sender) - 2)].Children.Add(editableTask);
                }


                //if (Grid.GetRow((Grid)sender) + 3 * (Grid.GetColumn((Grid)sender) - 2) < 0)
                //    stackPanels[0].Children.Add(new EditableTask(editableTask.title, editableTask.info));
                //else
                //    stackPanels[Grid.GetRow((Grid)sender) + 3 * (Grid.GetColumn((Grid)sender) - 2)].Children.Add(new EditableTask(editableTask.title, editableTask.info));
                //Console.WriteLine(editableTask.title + " " + editableTask.info);
            }

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.LeftShift) && mainUser.canEdit)
                MainWindow.shiftIsPressed = true;
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.LeftShift) && mainUser.canEdit)
                MainWindow.shiftIsPressed = false;
        }
    }
}
