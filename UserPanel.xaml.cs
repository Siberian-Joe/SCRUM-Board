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
    public partial class UserPanel : UserControl
    {
        public User user { get; set; }

        public UserPanel()
        {
            InitializeComponent();
        }

        public void setUser(User user)
        {
            this.user = user;

            fullNameTextBlock.Text = user.fullName;
            usernameTextBlock.Text = user.username;

            if (user.canEdit)
                managerTextBlock.Text = "Менеджер";
            else
                managerTextBlock.Text = "Пользователь";

            this.user = user;
        }

    }
}
