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
using RestaurantLibrary;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace RestaurantWPF
{

    public partial class ReservationWPF : Window
    {
        public ReservationWPF()
        {
            InitializeComponent();
            LoadTime();

            for (int i = 1; i <= 8; i++)
            {
                TableComoboBox.Items.Add(i);
            }


        }
        public void ReserveTable_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int guests = int.Parse(txtGuests.Text);
                string name = txtName.Text;
                string time = timeComboBox.SelectedItem?.ToString();
                int tableNum = int.Parse(TableComoboBox.SelectedItem?.ToString());
                DateTime selectedDate = dpDate.SelectedDate ?? DateTime.Now;

                DataBaseHandler dataBaseHandler = new DataBaseHandler("46.139.116.158", 3307, "restaurant_database", "RemoteUser", "remoteUserPassword");
                int reservationId = dataBaseHandler.GetNextReservationId();

                dataBaseHandler.InsertReservation(reservationId, selectedDate, guests, tableNum, name);

                MessageBox.Show($"Name: {name}\nReservation Id: {reservationId}\nNumber of guests: {guests}\nTime: {time}\nTable Number: {tableNum}\nSelected Date: {selectedDate.ToShortDateString()}");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void Back_To_Main(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void TimeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void LoadTime()
        {
            List<string> times = new List<string>();


            for (int hour = 10; hour <= 20; hour++)
            {
                for (int minute = 0; minute < 60; minute += 30)
                {
                    string time = $"{hour.ToString("00")}:{minute.ToString("00")}";
                    if (hour == 22 && minute == 30)
                        break;
                    times.Add(time);
                }
            }

            timeComboBox.ItemsSource = times;
        }

        private void ExampleTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Number")
            {
                textBox.Text = "";
            }
        }
        private void ExampleNameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Your name")
            {
                textBox.Text = "";
            }
        }

        private void ExampleTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Number";
            }
        }
        private void ExampleNameBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Your name";
            }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

