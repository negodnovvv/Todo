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

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            this.Hide();
        }

        private void LoginTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Убираем подсказку
            if (LoginBox.Text == "Введите имя пользователя")
            {
                LoginBox.Text = "";
                LoginBox.Foreground = Brushes.Black;
            }
        }

        private void LoginTextBox_Lost1Focus(object sender, RoutedEventArgs e)
        {
            // Возвращаем подсказку
            if (string.IsNullOrWhiteSpace(LoginBox.Text))
            {
                LoginBox.Text = "Введите имя пользователя";
                LoginBox.Foreground = Brushes.Gray;
            }
        }

        private void EmailTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Убираем подсказку
            if (emailbox.Text == "exam@yandex.ru")
            {
                emailbox.Text = "";
                emailbox.Foreground = Brushes.Black;
            }
        }

        private void EmailTextBox_Lost1Focus(object sender, RoutedEventArgs e)
        {
            // Возвращаем подсказку
            if (string.IsNullOrWhiteSpace(emailbox.Text))
            {
                emailbox.Text = "exam@yandex.ru";
                emailbox.Foreground = Brushes.Gray;
            }
        }

        private void Password1TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Убираем подсказку
            if (Password1.Text == "Введите пароль")
            {
                Password1.Text = "";
                Password1.Foreground = Brushes.Black;
            }
        }

        private void Password1TextBox_Lost1Focus(object sender, RoutedEventArgs e)
        {
            // Возвращаем подсказку
            if (string.IsNullOrWhiteSpace(Password1.Text))
            {
                Password1.Text = "Введите пароль";
                Password1.Foreground = Brushes.Gray;
            }
        }

        private void Password2TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Убираем подсказку
            if (Password2.Text == "Повторите пароль")
            {
                Password2.Text = "";
                Password2.Foreground = Brushes.Black;
            }
        }

        private void Password2TextBox_Lost1Focus(object sender, RoutedEventArgs e)
        {
            // Возвращаем подсказку
            if (string.IsNullOrWhiteSpace(Password2.Text))
            {
                Password2.Text = "Повторите пароль";
                Password2.Foreground = Brushes.Gray;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
                string login = LoginBox.Text;
                string email = emailbox.Text;
                string password1 = Password1.Text;
                string password2 = Password2.Text;

                if (login == "Введите имя пользователя") login = "";
                if (email == "exam@yandex.ru") email = "";
                if (password1 == "Введите пароль") password1 = "";
                if (password2 == "Повторите пароль") password2 = "";
        }
    }
}


