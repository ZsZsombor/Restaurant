using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Policy;
using System.Xml.Linq;

namespace RestaurantLibrary
{
    public class DataBaseHandler : IDisposable
    {
        private readonly string _connectionString;
        private MySqlConnection _connection;

        public DataBaseHandler(string server, int port, string database, string username, string password)
        {
            _connectionString = $"server={server};port={port};database={database};user={username};password={password};";
            Console.WriteLine($"Connection String: {_connectionString}");

            try
            {
                _connection = new MySqlConnection(_connectionString);
                _connection.Open();
                Console.WriteLine("Connection successful.");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
                throw;
            }
        }

        public List<(int TableNumber, bool IsOccupied)> GetAvailableTables()
        {
            var tables = new List<(int TableNumber, bool IsOccupied)>();
            string query = "SELECT * FROM Tables WHERE IsOccupied = FALSE";
            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tables.Add((reader.GetInt32("TableNumber"), reader.GetBoolean("IsOccupied")));
                    }
                }
            }
            return tables;
        }

        public int GetNextReservationId()
        {
            string query = "SELECT MAX(ReservationId) FROM Reservations";
            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                return Convert.ToInt32(cmd.ExecuteScalar()) + 1;
            }
        }

        public int GetNextOrderId()
        {
            string query = "SELECT MAX(OrderId) FROM Orders";
            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                return Convert.ToInt32(cmd.ExecuteScalar()) + 1;
            }
        }

        public int GetNextBillId()
        {
            string query = "SELECT MAX(BillId) FROM Bills";
            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                return Convert.ToInt32(cmd.ExecuteScalar()) + 1;
            }
        }

        public bool ReservationExists(string name, DateTime date)
        {
            string query = "SELECT COUNT(*) FROM Reservations WHERE Name = @name AND Date = @date";
            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@date", date);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public void InsertReservation(int reservationId, DateTime date, int numberOfPeople, int tableNumber, string name)
        {
            if (ReservationExists(name, date))
            {
                throw new Exception("Reservation already exists for the specified name and date.");
            }

            string query = "INSERT INTO Reservations (ReservationId, Date, NumberOfPeople, TableNumber, Name) VALUES (@reservationId, @date, @numberOfPeople, @tableNumber, @name)";
            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@reservationId", reservationId);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@numberOfPeople", numberOfPeople);
                cmd.Parameters.AddWithValue("@tableNumber", tableNumber);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
            }
        }
 


        public void DeleteReservation(int reservationId)
    {
        string query = "DELETE FROM Reservations WHERE ReservationId = @reservationId";
        using (MySqlCommand cmd = new MySqlCommand(query, _connection))
        {
                cmd.Parameters.AddWithValue("@reservationId", reservationId);
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertOrder(int orderId, int tableNumber, string items)
        {
            string query = "INSERT INTO Orders (OrderId, TableNumber, Items) VALUES (@orderId, @tableNumber, @items)";
            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@orderId", orderId);
                cmd.Parameters.AddWithValue("@tableNumber", tableNumber);
                cmd.Parameters.AddWithValue("@items", items);
                cmd.ExecuteNonQuery();
            }
        }

        public List<(int OrderId, int TableNumber, string Items)> GetOrdersForTable(int tableNumber)
        {
            var orders = new List<(int OrderId, int TableNumber, string Items)>();
            string query = "SELECT * FROM Orders WHERE TableNumber = @tableNumber";
            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@tableNumber", tableNumber);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orders.Add((reader.GetInt32("OrderId"), reader.GetInt32("TableNumber"), reader.GetString("Items")));
                    }
                }
            }
            return orders;
        }

        public void InsertBill(int billId, int tableNumber, decimal totalAmount)
        {
            string query = "INSERT INTO Bills (BillId, TableNumber, TotalAmount) VALUES (@billId, @tableNumber, @totalAmount)";
            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@billId", billId);
                cmd.Parameters.AddWithValue("@tableNumber", tableNumber);
                cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                cmd.ExecuteNonQuery();
            }
        }

        public void Dispose()
        {
            _connection?.Close();
            _connection?.Dispose();
        }
    }
}