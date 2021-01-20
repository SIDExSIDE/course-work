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
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BtnReg_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if ((String) BtnReg.Content == "Регистрация")
            {
                BtnReg.Content = "Вход";
                LabelTitle.Content = "Регистрация";
                BtnAuth.Content = "Зарегистрироваться";
                this.Title = "Регистрация";
            }
            else
            {
                BtnReg.Content = "Регистрация";
                LabelTitle.Content = "Вход";
                BtnAuth.Content = "Войти";
                this.Title = "Аторизация";
            }

        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {

            /* АВТОРИЗАЦИЯ */

            if ((String) BtnAuth.Content == "Войти")     
            {
                var user = new Users();
                string log = Login.Text;
                string pass = Password.Password;

                if (log == "" || pass == "")
                {
                    MessageBox.Show("Укажите логин и пароль\n" +
                        "в соответствующих полях ввода!",
                        "Ошибка авторизиции");
                }
                else
                {
                    try
                    {
                        user = repositoryUsers.GetByLogin(log);
                        if (user.password == pass) /* ВСЕ ДАННЫЕ УКАЗАНЫ ВЕРНО */
                        {
                            Window MenuWindow = new MenuWindow();
                            MenuWindow.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Неверно введен пароль!", 
                                "Ошибка авторизации");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Пользователь с таким логином не найден!", 
                            "Ошибка авторизации");
                    }
                }
            }

            /* РЕГИСТРАЦИЯ */

            else
            {
                string log = Login.Text;
                string pass = Password.Password;

                if (log == "" || pass == "")
                {
                    MessageBox.Show("Укажите логин и пароль\n" +
                        "в соответствующих полях ввода!", 
                        "Ошибка регистрации");
                }
                else
                {
                    var data = new Users();
                    data.login = log;
                    data.password = pass;

                    try
                    {
                        repositoryUsers.AddUser(data);
                        MessageBox.Show("Регистрация завершена!");
                    }
                    catch
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует", 
                            "Ошибка регистрации");
                    }
                }
            }
        }
    }
}
