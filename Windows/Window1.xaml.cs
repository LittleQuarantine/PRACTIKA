using Practika.Windows;
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

namespace Practika.Windows
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            TextBox3.Visibility = Visibility.Hidden;
            TextBox4.Visibility = Visibility.Hidden;

            Button5.Visibility = Visibility.Hidden;
            Button6.Visibility = Visibility.Hidden;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mW = new MainWindow();
            mW.Show();
            this.Hide();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Button5.Visibility = Visibility.Visible;
            Button3.Visibility = Visibility.Hidden;

            TextBox3.Visibility = Visibility.Visible;
            PasswordBox3.Visibility = Visibility.Hidden;

            TextBox3.Text = PasswordBox3.Password;
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Button6.Visibility = Visibility.Visible;
            Button4.Visibility = Visibility.Hidden;

            TextBox4.Visibility = Visibility.Visible;
            PasswordBox4.Visibility = Visibility.Hidden;

            TextBox4.Text = PasswordBox4.Password;
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Button3.Visibility = Visibility.Visible;
            Button5.Visibility = Visibility.Hidden;

            PasswordBox3.Visibility = Visibility.Visible;
            TextBox3.Visibility = Visibility.Hidden;

            PasswordBox3.Password = TextBox3.Text;
        }
        
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Button4.Visibility = Visibility.Visible;
            Button6.Visibility = Visibility.Hidden;

            PasswordBox4.Visibility = Visibility.Visible;
            TextBox4.Visibility = Visibility.Hidden;

            PasswordBox4.Password = TextBox4.Text;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            var login = TextBox1.Text;
            var email = TextBox2.Text;
            var password = TextBox4.Text;

            var context = new AppDbContext();

            var user_existLog = context.Users.FirstOrDefault(x => x.Login == login);
            if (user_existLog is not null)
            {
                tb1.Text = "Такой пользователь уже есть";
                return;
            }
            
            var user = new User { Login = login, Email = email, Password = password };
            context.Users.Add(user);
            context.SaveChanges();
            MessageBox.Show("Регистрация прошла успешно");
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextBox1.Text.Length > 18)
            {
                tb1.Text = "Логин не должен превышать 18 символов";
            }
        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            string email = TextBox2.Text;
            char requiredSymbol = '@';
            if (email.Contains(requiredSymbol))
            {

            }
            else
            {
                tb2.Text = "Email неверно указан";
                
            }
        }

        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            string password = PasswordBox3.Password;
            if (ContainsSpecChar(password))
            {

            }
            else
            {
                tb3.Text = "Пароль должен содержать в себе символы !@#$%^&*()_+-=;:,.? ";
            }

        }
        private bool ContainsSpecChar(string password)
        {
            string specialChar = "!@#$%^&*()_+-=;:,.?";
            foreach (char c in specialChar)
            {
                if (password.Contains(c))
                {
                    return true;
                }    
            }
            return false;
        }

        private void TextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PasswordBox4.Password != PasswordBox3.Password)
            {
                tb4.Text = "Пароли не совпадают";
            }
        }
    }
}
