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
using System.Windows.Shapes;
using WpfApp1.Models.Users;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AddSessionWindow.xaml
    /// </summary>
    public partial class AddSessionWindow : Window
    {
        public AddSessionWindow()
        {
            InitializeComponent();
        }

        private void testComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            var user = new Users();

            user = repositoryUsers.TEST();

            testComboBox.Items.Add(user.login);
        }
    }
}
