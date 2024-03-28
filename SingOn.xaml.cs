using PractikaChanged1;
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

namespace PractikaChanged
{
    /// <summary>
    /// Логика взаимодействия для SingOn.xaml
    /// </summary>
    public partial class SingOn : Window
    {
        public SingOn()
        {
            InitializeComponent();

            TextBox3.Visibility = Visibility.Hidden;
            TextBox4.Visibility = Visibility.Hidden;
            Button5.Visibility = Visibility.Hidden;
            Button6.Visibility = Visibility.Hidden;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow si = new MainWindow();
            si.Show();
            this.Hide();
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
            SolidColorBrush brush = new SolidColorBrush(Colors.IndianRed);
            if (TextBox1.Text.Length > 18)
            {
                tb1.Text = "Логин не должен превышать 18 символов";
                TextBox1.BorderBrush = brush;
                return;
            }

            string email1 = TextBox2.Text;
            char requiredSymbol1 = '@';
            if (email1.Contains(requiredSymbol1))
            {

            }
            else
            {
                tb2.Text = "Email неверно указан";
                TextBox2.BorderBrush = brush;
                return;

            }

            char requiredSymbol2 = '!';
            char requiredSymbol3 = '#';
            char requiredSymbol4 = '$';
            char requiredSymbol5 = '%';
            string password1 = PasswordBox3.Password;
            if ((password1.Contains(requiredSymbol1)) || (password1.Contains(requiredSymbol2)) || (password1.Contains(requiredSymbol3)) || (password1.Contains(requiredSymbol4)) || (password1.Contains(requiredSymbol5)))
            {

            }
            else
            {
                tb3.Text = "Пароль должен содержать в себе символы !@#$%";
                PasswordBox3.BorderBrush = brush;
                TextBox3.BorderBrush = brush;
                return;
            }

            if (PasswordBox4.Password != PasswordBox3.Password || TextBox3.Text != TextBox4.Text)
            {
                tb4.Text = "Пароли не совпадают";
                PasswordBox4.BorderBrush = brush;
                TextBox4.BorderBrush = brush;
                return;
            }

            var login = TextBox1.Text;
            var email = TextBox2.Text;
            var password = PasswordBox3.Password;
            var context = new AppDbContext();
            var user_exists = context.Users.FirstOrDefault(x => x.Login == login);
            if (user_exists is not null)
            {
                MessageBox.Show("Такой пользователь уже есть");
            }
            var user = new User { Login = login, Email = email, Password = password};
            context.Users.Add(user);
            context.SaveChanges();
            
            MainWindow mn = new MainWindow();
            mn.Show();
            this.Hide();
        }
    }
}
