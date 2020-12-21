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
using WpfApp1.Models.Users;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window LoginWindow = new LoginWindow();
            LoginWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window MenuWindow = new MenuWindow();
            MenuWindow.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string log = login.Text;
            string pass = password.Text;

            var data = new Users();
            data.login = log;
            data.password = pass;
            repositoryUsers.AddUser(data);
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            string log = login.Text;
            var user = new Users();
            //user = repositoryUsers.GetById();
            //MessageBox.Show(user.login);
        }
    }
}