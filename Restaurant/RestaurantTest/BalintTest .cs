using RestaurantLibrary;

namespace RestaurantTest
{
    public class BalintTests
    {
        private Restaurant _restaurant;
        private List<Table> _tables;
        private List<Reservation> _reservations;
        private List<Order> _orders;
        private List<Bill> _bills;

        [SetUp]
        public void Setup()
        {
            var name = "Bálint";
            _tables = new List<Table>
        {
            new Table(1, false),
            new Table(2, true),
            new Table(3, false)
        };

            _reservations = new List<Reservation>
        {
            new Reservation(name, 1, DateTime.Today.AddDays(1), 4, 1),
            new Reservation(name, 2, DateTime.Today.AddDays(2), 2, 3)
        };

            _orders = new List<Order>
        {
            new Order(1, 1, new List<string> { "Burger", "Fries" }),
            new Order(2, 2, new List<string> { "Pizza", "Coke" })
        };

            _bills = new List<Bill>
        {
            new Bill(1, 1, 25.50),
            new Bill(2, 2, 15.00)
        };

            _restaurant = new Restaurant(_tables, _reservations, _orders, _bills);
        }

        [Test]
        public void MakeReservation_TableOccupiedAfterReservation()
        {
            var name = "Bálint";
            var newReservation = new Reservation(name, 3, DateTime.Today.AddDays(3), 3, 2);

            _restaurant.MakeReservation(newReservation,
            _restaurant.Get_tables());

            var reservedTable = _restaurant.Tables.FirstOrDefault(t => t.TableNumber == newReservation.TableNumber);
            Assert.IsTrue(reservedTable.IsOccupied);
        }

        [Test]
        public void SaveToJson_FileExistsAfterSaving()
        {
            string filePath = "restaurant_data.json";

            _restaurant.SaveToJson(filePath);

            Assert.IsTrue(File.Exists(filePath));

            File.Delete(filePath);
        }

        [Test]
        public void PlaceOrder_AddsOrderToOrdersList()
        {
            var initialOrdersCount = _restaurant.Orders.Count();

            var newOrder = new Order(3, 2, new List<string> { "Pasta", "Salad" });
            _restaurant.PlaceOrder(newOrder);

            Assert.IsTrue(_restaurant.Orders.Contains(newOrder));
            Assert.AreEqual(initialOrdersCount + 1, _restaurant.Orders.Count());
        }

        [Test]
        public void MakeReservation_OccupiesCorrectTable()
        {
            var name = "Bálint";
            var availableTableNumber = _restaurant.GetAvailableTables().First().TableNumber;

            var newReservation = new Reservation(name, 4, DateTime.Today.AddDays(3), 2, availableTableNumber);
            _restaurant.MakeReservation(newReservation, _restaurant.Get_tables());

            var reservedTable = _restaurant.Tables.FirstOrDefault(t => t.TableNumber == availableTableNumber);
            Assert.IsTrue(reservedTable.IsOccupied);
        }
    }
}