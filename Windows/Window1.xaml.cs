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

        

        private void TextBox1_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "Email")
            {
                TextBox1.Text = "";
            }
        }

        private void TextBox1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox1.Text))
            {
                TextBox1.Text = "Email";
            }
        }
        
        private void TextBox2_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TextBox2.Text == "Логин")
            {
                TextBox2.Text = "";
            }
        }

        private void TextBox2_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox2.Text))
            {
                TextBox2.Text = "Логин";
            }
        }

        private void TextBox3_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TextBox3.Text == "Пароль")
            {
                TextBox3.Text = "";
            }
        }

        private void TextBox3_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox3.Text))
            {
                TextBox3.Text = "Пароль";
            }
        }

        private void TextBox4_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TextBox4.Text == "Повторите пароль")
            {
                TextBox4.Text = "";
            }
        }

        private void TextBox4_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox4.Text))
            {
                TextBox4.Text = "Повторите пароль";
            }
        }
    }
}
