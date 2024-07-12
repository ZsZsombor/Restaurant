using RestaurantLibrary;

namespace RestaurantTest
{
    public class ZalanTests
    {
        private Restaurant _restaurant;
        private List<Table> _tables;
        private List<Reservation> _reservations;
        private List<Order> _orders;
        private List<Bill> _bills;

        private readonly string filePath = "restaurant_data.json";

        [SetUp]
        public void Setup()
        {
            var name = "Zalán";
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
        public void PlaceOrder_AddsOrder()
        {
            var newOrder = new Order(3, 3, new List<string> { "Steak", "Wine" });

            _restaurant.PlaceOrder(newOrder);

            Assert.IsTrue(_restaurant.Orders.Contains(newOrder));
        }

        [Test]
        public void GenerateBill_AddsBill()
        {
            var newBill = new Bill(3, 3, 45.75);

            _restaurant.GenerateBill(newBill);

            Assert.IsTrue(_restaurant.Bills.Contains(newBill));
        }

        [Test]
        public void SaveToJson_SavesToFilePath()
        {
            _restaurant.SaveToJson(filePath);

            Assert.IsTrue(File.Exists(filePath));

            File.Delete(filePath);
        }

        [Test]
        public void LoadFromJson_RestaurantNotNull()
        {
            _restaurant.SaveToJson(filePath);

            var loadedRestaurant = Restaurant.LoadFromJson(filePath);

            Assert.IsNotNull(loadedRestaurant);

            File.Delete(filePath);
        }
    }
}