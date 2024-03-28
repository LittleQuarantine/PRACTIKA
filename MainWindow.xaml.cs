using PractikaChanged;
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

namespace PractikaChanged1
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
            SingOn sn = new SingOn();
            sn.Show();
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            var login = TextBox1.Text;
            var email = TextBox1.Text;
            var password = TextBox2.Text;
            var context = new AppDbContext();
            var user = context.Users.SingleOrDefault(x => x.Login == login || x.Email == email && x.Password == password);
            if(user is null)
            {
                tb1.Text = "Неправильный логин или пароль";
                return;
            }

            Welcome welcome = new Welcome(login, user.Id);
            welcome.Show();
            this.Hide();
        }
    }
}