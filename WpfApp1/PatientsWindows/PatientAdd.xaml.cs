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
    /// Логика взаимодействия для PatientAdd.xaml
    /// </summary>
    public partial class PatientAdd : Window
    {
        public PatientAdd()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var data = new Patients(
                    name.Text
                );

            try
            {
                repositoryPatients.AddPatient(data);
            }

            catch (Exception error)
            {
                MessageBox.Show($"Отсутствует подключение к базе данных. \n Сообщение ошибки: ${error.Message}");
                this.Close();
                return;
            }

            MessageBox.Show("Запись успешно добавлена.");
            this.Close();
        }
    }
}
