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

namespace WPF._1.Layout
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<User> users;
        public MainWindow()
        {
            InitializeComponent();
            users = new List<User>
            {
                new User
                {
                    Avatar = "/Resources/logo.png",
                    Name = "飞翔的蜗牛",
                    Date = "07-03"
                },new User
                {
                    Avatar = "/Resources/logo.png",
                    Name = "飞翔的蜗牛",
                    Date = "07-03"
                },new User
                {
                    Avatar = "/Resources/logo.png",
                    Name = "飞翔的蜗牛",
                    Date = "07-03"
                },new User
                {
                    Avatar = "/Resources/logo.png",
                    Name = "飞翔的蜗牛",
                    Date = "07-03"
                }
            };

            UserList.ItemsSource = users;
        }
    }

    internal class User
    {
        public string Name { get; set; }

        public string Avatar { get; set; }

        public string Date { get; set; }
    }
}
