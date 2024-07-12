using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary
{
    public class Bill
    {
        public int BillId { get; set; }
        public int TableNumber { get; set; }
        public double TotalAmount { get; set; }

        public Bill(int BillId, int TableNumber, double TotalAmount) 
        {
            this.BillId = BillId;
            this.TableNumber = TableNumber;
            this.TotalAmount = TotalAmount;
        }
    }
}
