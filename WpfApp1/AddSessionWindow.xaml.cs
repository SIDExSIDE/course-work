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

            List<Doctors> doctorsData = repositorySession.GetAllDoctors();
            var cbListDoctors = new List<string>();

            foreach (var i in doctorsData)
            {
                cbListDoctors.Add($"{i.Name}");
            }

            cbDoctors.ItemsSource = cbListDoctors;


            List<Patients> patientsData = repositorySession.GetAllPatients();
            var cbListPatients = new List<string>();

            foreach (var i in patientsData)
            {
                cbListPatients.Add($"{i.Name}");
            }

            cbPatients.ItemsSource = cbListPatients;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window MenuWindow = new MenuWindow();
            MenuWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var data = new Session(
                    cbPatients.Text,
                    cbDoctors.Text,
                    time.Text,
                    Int32.Parse(price.Text)
                );

            try
            {
                repositorySession.Add(data);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Отсутствует подключение к базе данных. \n Сообщение ошибки: ${error.Message}");
                this.Close();
                return;
            }

            MessageBox.Show("Запись успешно добавлена.");
        }
    }
}
