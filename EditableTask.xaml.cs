using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для EditableTask.xaml
    /// </summary>
    public partial class EditableTask : UserControl
    {
        public string title { get; set; }
        public string info { get; set; }
        public int oldColumn { get; set; }
        public int oldRow { get; set; }
        public int column { get; set; }
        public int row { get; set; }
        public StackPanel oldStackPanel { get; set; }
        public StackPanel stackPanel { get; set; }
        public EditableTask()
        {
            InitializeComponent();
            title = titleTextBlock.Text;
            info = textBlock.Text;
        }

        public EditableTask(string title, string info, int column, int row)
        {
            InitializeComponent();

            titleTextBlock.Text = title;
            textBlock.Text = info;

            this.column = column;
            this.row = row;

            this.title = title;
            this.info = info;
        }
        private void expanderExpanded(object sender, RoutedEventArgs e)
        {
            expander.Height = 123;
            expander.Margin = new Thickness(0, 0, 0, -100);
            collapsedGrid.Height = 160;
        }
        private void expanderCollapsed(object sender, RoutedEventArgs e)
        {
            expander.Height = 23;
            expander.Margin = new Thickness(0);
            collapsedGrid.Height = 60;
        }
        private void cancelRichTextBoxEdit()
        {
            richTextBox.Visibility = Visibility.Hidden;
        }

        private void acceptRichTextBoxEdit()
        {
            textBlock.Text = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd).Text;
            richTextBox.Visibility = Visibility.Hidden;
            title = titleTextBlock.Text;
            info = textBlock.Text;
        }
        private void cancelTitleTextBoxEdit()
        {
            titleTextBlock.Visibility = Visibility.Visible;
            titleTextBox.Visibility = Visibility.Hidden;
        }

        private void acceptTitleTextBoxEdit()
        {
            titleTextBlock.Visibility = Visibility.Visible;
            titleTextBox.Visibility = Visibility.Hidden;

            if (titleTextBox.Text.Length != 0)
            {
                titleTextBlock.Text = titleTextBox.Text;
                title = titleTextBlock.Text;
            }            
        }


        private void userControlMouseEnter(object sender, MouseEventArgs e)
        {
            if(MainWindow.mainUser.canEdit)
                gridDeleteButton.Visibility = Visibility.Visible;
        }

        private void userControlMouseLeave(object sender, MouseEventArgs e)
        {
            if (MainWindow.mainUser.canEdit)
                gridDeleteButton.Visibility = Visibility.Collapsed;
        }

        private void deleteButtonClick(object sender, RoutedEventArgs e)
        {
            ((Panel)this.Parent).Children.Remove(this);
        }

        private void textBlockMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (MainWindow.mainUser.canEdit)
            {
                richTextBox.Visibility = Visibility.Visible;
                richTextBox.Focus();
            }
        }

        private void richTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            string message = "Сохранить?";
            string caption = "Изменение данных";
            MessageBoxButton buttons = MessageBoxButton.YesNo;

            if (MessageBox.Show(message, caption, buttons, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                string text = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd).Text;
                if (text.Length != 0)
                    acceptRichTextBoxEdit();
                else
                {
                    MessageBox.Show("Введите данные!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    cancelRichTextBoxEdit();
                }
            }
            else
            {
                cancelRichTextBoxEdit();
            }
        }
        private void titleTextBlockMouseUp(object sender, MouseButtonEventArgs e)
        {
            titleTextBlock.Visibility = Visibility.Collapsed;
            titleTextBox.Visibility = Visibility.Visible;

            titleTextBox.Focus();
        }
        private void titleTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            string message = "Сохранить?";
            string caption = "Изменение данных";
            MessageBoxButton buttons = MessageBoxButton.YesNo;

            if (MessageBox.Show(message, caption, buttons, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                if (titleTextBox.Text.Length != 0)
                    acceptTitleTextBoxEdit();
                else
                {
                    MessageBox.Show("Введите данные!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    cancelTitleTextBoxEdit();
                }
            }
            else
            {
                cancelTitleTextBoxEdit();
            }
        }
        private void titleTextBlock_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (MainWindow.mainUser.canEdit)
            {
                titleTextBlock.Visibility = Visibility.Collapsed;
                titleTextBox.Visibility = Visibility.Visible;

                titleTextBox.Focus();
            }
        }
        private void UserControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (MainWindow.shiftIsPressed)
            {
                EditableTask editableTask = (EditableTask)sender;
                DataObject dataObject = new DataObject(editableTask);
                //Console.WriteLine(editableTask.title);
                DragDrop.DoDragDrop(editableTask, dataObject, DragDropEffects.Move);
                //((Panel)this.Parent).Children.Remove(this);
            }
        }
    }
}
