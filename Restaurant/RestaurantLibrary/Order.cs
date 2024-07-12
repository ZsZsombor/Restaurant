using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary
{
    public class Order
    {
        public int OrderId { get; set; }
        public int TableNumber { get; set; }
        public List<string> Items { get; set; }

        public Order(int OrderId, int TableNumber, List<string> Items)
        {
            this.OrderId = OrderId;
            this.TableNumber = TableNumber;
            this.Items = Items;
        }
    }
}
