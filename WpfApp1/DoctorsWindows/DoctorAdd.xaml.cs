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

namespace WpfApp1.DoctorsWindows
{
    /// <summary>
    /// Логика взаимодействия для DoctorAdd.xaml
    /// </summary>
    public partial class DoctorAdd : Window
    {
        public DoctorAdd()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var data = new Doctors(
                    name.Text,
                    type.Text
                );

            try
            {
                repositoryDoctors.AddDoctor(data);
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
