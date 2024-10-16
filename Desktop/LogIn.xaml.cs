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

namespace Desktop
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

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordBox.Text;

            if (email == "pangcheo1210@gmail.com") email = "";
            if (password == "Введите пароль") password = "";
        }

        private void EmailTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Убираем подсказку
            if (EmailTextBox.Text == "pangcheo1210@gmail.com")
            {
                EmailTextBox.Text = "";
                EmailTextBox.Foreground = Brushes.Black;
            }
        }
       
        private void EmailTextBox_Lost1Focus(object sender, RoutedEventArgs e)
        {
            // Возвращаем подсказку
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                EmailTextBox.Text = "pangcheo1210@gmail.com";
                EmailTextBox.Foreground = Brushes.Gray;
            }
        }

        private void PasswordTextBox_Got1Focus(object sender, RoutedEventArgs e)
        {
            // Убираем подсказку
            if (PasswordBox.Text == "Введите пароль")
            {
                PasswordBox.Text = "";
                PasswordBox.Foreground = Brushes.Black;
            }
        }

        private void PasswordTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            // Возвращаем подсказку
            if (string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                PasswordBox.Text = "Введите пароль";
                PasswordBox.Foreground = Brushes.Gray;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var registrtion = new Registration();
            registrtion.Show();
            this.Hide();
        }
    }
}
