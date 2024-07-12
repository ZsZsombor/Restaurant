using RestaurantLibrary;

namespace RestaurantTest
{
    public class ZsomborTests
    {
        private Restaurant _restaurant;
        private List<Table> _tables;
        private List<Reservation> _reservations;
        private List<Order> _orders;
        private List<Bill> _bills;

        [SetUp]
        public void Setup()
        {
            var name = "Zsombor";
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
        public void MakeReservation_AddsReservation()
        {
            var name = "Zsombor";
            var newReservation = new Reservation(name, 3, DateTime.Today.AddDays(3), 3, 2);

            _restaurant.MakeReservation(newReservation,
            _restaurant.Get_tables());

            Assert.IsTrue(_restaurant.Reservations.Contains(newReservation));
        }

        [Test]
        public void CancelReservation_RemovesReservation()
        {
            var name = "Zsombor";
            int reservationIdToRemove = 1;

            _restaurant.CancelReservation(name, reservationIdToRemove);

            Assert.IsFalse(_restaurant.Reservations.Any(r => r.ReservationId == reservationIdToRemove));
        }

        [Test]
        public void CancelReservation_RemovesReservationFromList()
        {
            var name = "Zsombor";
            int reservationIdToRemove = 1;

            _restaurant.CancelReservation(name, reservationIdToRemove);

            Assert.IsFalse(_restaurant.Reservations.Any(r => r.ReservationId == reservationIdToRemove));
        }

        [Test]
        public void CancelReservation_ThrowsExceptionWhenReservationNotFound()
        {
            var name = "Zsombor";
            Assert.Throws<CouldntFindReservationException>(() => _restaurant.CancelReservation(name, 999));
        }
    }
}