using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HUWATIExpress.Models
{
    public class AvailableSeatByTripListItem
    {
        public int Trip_Id { get; set; }
        public int Bus_Id { get; set; }
        public int Seat_Id { get; set; }
    }
}