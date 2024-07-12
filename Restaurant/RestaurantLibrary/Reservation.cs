using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary
{
    public class Reservation
    {
        public string Name { get; set; }
        public int ReservationId { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfPeople { get; set; }
        public int TableNumber { get; set; }

        public Reservation(string Name, int ReservationId, DateTime Date, int NumberOfPeople, int TableNumber) 
        {
            this.Name = Name;  
            this.ReservationId = ReservationId;
            this.Date = Date;
            this.NumberOfPeople = NumberOfPeople;
            this.TableNumber = TableNumber;
        }
    }
}
