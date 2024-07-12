using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary
{
    public class CouldntFindReservationException : Exception
    {
        public CouldntFindReservationException():base("The reservation that you are trying to cancel is not in the database.") { }
    }
}
