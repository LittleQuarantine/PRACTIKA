using Practika.Windows;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practika
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            TextBox2.Visibility = Visibility.Hidden;
            Button4.Visibility = Visibility.Hidden;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Window1 reg = new Window1();
            reg.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Button4.Visibility = Visibility.Visible;
            Button3.Visibility = Visibility.Hidden;

            PasswordBox1.Visibility = Visibility.Hidden;
            TextBox2.Visibility = Visibility.Visible;

            TextBox2.Text = PasswordBox1.Password;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Button3.Visibility = Visibility.Visible;
            Button4.Visibility = Visibility.Hidden;

            TextBox2.Visibility = Visibility.Hidden;
            PasswordBox1.Visibility = Visibility.Visible;

            PasswordBox1.Password = TextBox2.Text;
        }
    }
}