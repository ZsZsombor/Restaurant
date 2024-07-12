using RestaurantLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Xml.Linq;

namespace RestaurantWPF
{
    /// <summary>
    /// Interaction logic for CancelWindow.xaml
    /// </summary>
    public partial class CancelWindow : Window
    {
        public CancelWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = NameInput.Text;
                int reservationId = int.Parse(ReservationIdInput.Text);

                DataBaseHandler dataBaseHandler = new DataBaseHandler("46.139.116.158", 3307, "restaurant_database", "RemoteUser", "remoteUserPassword"); ;

                dataBaseHandler.DeleteReservation(reservationId);

                MessageBox.Show("Your reservation has been cancelled!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void NewReserv_Click(object sender, RoutedEventArgs e)
        {
            ReservationWPF reservation = new ReservationWPF();
            reservation.Show();
            Close();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void ExampleTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "id")
            {
                textBox.Text = "";
            }
        }
        private void ExampleNameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Name")
            {
                textBox.Text = "";
            }
        }

        private void ExampleTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "id";
            }
        }
        private void ExampleNameBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Name";
            }
        }

    }
}
