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
    /// Логика взаимодействия для Welcome.xaml
    /// </summary>
    public partial class Welcome : Window
    {
        public string UserLogin { get; }
        public int _id;
        public Welcome(string UserLogin, int id)
        {
            InitializeComponent();
            video.Source = new Uri("C:\\Users\\Student\\Desktop\\PractikaChanged1\\Media\\video.mp4");

            _id = id;
            int find = id;
            var context = new AppDbContext();
            var user = context.Users.SingleOrDefault(x => x.Id == id);
            string FindUser = user.Login;
            tb1.Text = "Здравствуйте, " + FindUser + "!";
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
