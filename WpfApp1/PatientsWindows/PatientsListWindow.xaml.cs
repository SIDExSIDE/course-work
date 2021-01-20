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
using WpfApp1.Models;
using WpfApp1.Repository;

namespace WpfApp1.PatientsWindows
{
    /// <summary>
    /// Логика взаимодействия для PatientsListWindow.xaml
    /// </summary>
    public partial class PatientsListWindow : Window
    {
        private void UpdateTable()
        {
            List<Patients> listPatients = repositoryPatients.GetAllPatients();
            dgPatients.ItemsSource = listPatients;
        }
        public PatientsListWindow()
        {
            InitializeComponent();
            UpdateTable();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window MenuWindow = new MenuWindow();
            MenuWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new PatientAdd().ShowDialog();
            UpdateTable();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new PatientDelete().ShowDialog();
            UpdateTable();
        }
    }
}
