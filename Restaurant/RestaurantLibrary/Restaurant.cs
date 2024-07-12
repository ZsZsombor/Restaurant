using System.IO;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;

namespace RestaurantLibrary
{
    public class Restaurant
    {
        public IEnumerable<Table> Tables => _tables;
        public IEnumerable<Reservation> Reservations => _reservations;
        public IEnumerable<Order> Orders => _orders;
        public IEnumerable<Bill> Bills => _bills;

        private readonly List<Table> _tables;
        private readonly List<Reservation> _reservations;
        private readonly List<Order> _orders;
        private readonly List<Bill> _bills;

        [JsonConstructor]
        public Restaurant(IEnumerable<Table> Tables, IEnumerable<Reservation> Reservations, IEnumerable<Order> Orders, IEnumerable<Bill> Bills)
        {
            _tables = Tables.ToList();
            _reservations = Reservations.ToList();
            _orders = Orders.ToList();
            _bills = Bills.ToList();  
        }

        public Restaurant()
        {
            _tables = new List<Table>();
            _reservations = new List<Reservation>();
            _orders = new List<Order>();
            _bills = new List<Bill>();
        }

        public void SaveToJson(string filePath)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(this, options);
            File.WriteAllText(filePath, json);
        }

        public static Restaurant LoadFromJson(string filePath)
        {
            string json = File.ReadAllText(filePath);
            Restaurant restaurant = JsonSerializer.Deserialize<Restaurant>(json);

            return restaurant;
        }

        public List<Table> Get_tables()
        {
            return _tables;
        }

        public void MakeReservation(Reservation reservation, List<Table> _tables)
        {
            _reservations.Add(reservation);
            _tables.Find(table => table.TableNumber == reservation.TableNumber).IsOccupied = true;

        }

        public void CancelReservation(string reservationName, int reservationId)
        {
            Reservation reservation = _reservations.Find(r => r.ReservationId == reservationId && r.Name == reservationName);
            if (reservation != null)
            {
                _reservations.Remove(reservation);
                _tables.Find(table => table.TableNumber == reservation.TableNumber).IsOccupied = false;
            }
            else
            {
                throw new CouldntFindReservationException();
            }
        }

        public IEnumerable<Table> GetAvailableTables()
        {
            return _tables.Where(table => !table.IsOccupied);
        }

        public void PlaceOrder(Order order)
        {
            _orders.Add(order);
        }

        public void GenerateBill(Bill bill)
        {
            _bills.Add(bill);
        }
    }
}