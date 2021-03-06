﻿using System;
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
    /// Логика взаимодействия для PatientDelete.xaml
    /// </summary>
    public partial class PatientDelete : Window
    {
        public PatientDelete()
        {
            InitializeComponent();

            List<Patients> allData = repositoryPatients.GetAllPatients();
            var cbList = new List<string>();

            foreach (var i in allData)
            {
                cbList.Add($"{i.Id}. {i.Name}");
            }

            cbName.ItemsSource = cbList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string cbText = cbName.Text;

            string id = cbText.Substring(0, cbText.IndexOf('.'));

            repositoryPatients.DeletePatient(Int32.Parse(id));

            MessageBox.Show("Запись успешно удалена");
            this.Close();
        }
    }
}
