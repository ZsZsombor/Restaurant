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
using System.Windows.Threading;

namespace RestaurantWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RestaurantLibrary.Restaurant restaurant;


        public MainWindow()
        {
            InitializeComponent();

        }
        public CornerRadius CornerRadius { get; set; }



    private void Menu_Click(object sender, RoutedEventArgs e)
        {
            MenuWPF menuWPF = new MenuWPF();
            menuWPF.Show();
            Close();
        }
        private void MakeReservation_Click(object sender, RoutedEventArgs e)
        {
            ReservationWPF reservation = new ReservationWPF();
            reservation.Show();
            Close();
        }

        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            ContactWindow contact = new ContactWindow();
            contact.Show();
            Close();
        }

        private void CancelReservation_Click(object sender, RoutedEventArgs e)
        {
            CancelWindow cancel = new CancelWindow();
            cancel.Show();
            Close();
        }

        private void closeApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void minimizeApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Minimized;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LogIn(object sender, RoutedEventArgs e)
        {
            login login = new login();
            login.Show();
            Close();
        }

        private void ProfileBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            ProfileBtn.Background = Brushes.Transparent;
        }
    }

}

