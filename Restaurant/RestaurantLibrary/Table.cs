using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary
{
    public class Table
    {
        public int TableNumber { get; set; }
        public bool IsOccupied { get; set; }

        public Table(int TableNumber, bool IsOccupied) 
        {
            this.TableNumber = TableNumber;
            this.IsOccupied = IsOccupied;
        }
    }
}
