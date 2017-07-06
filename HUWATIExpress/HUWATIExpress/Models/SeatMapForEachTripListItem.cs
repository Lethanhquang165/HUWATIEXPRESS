using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HUWATIExpress.Models
{
    public class SeatMapForEachTripListItem
    { 
        public int Bus_Id { get; set; }
        public string Seat_Code { get; set; }
        public int? Seat_Position { get; set; }
        public bool Available_Seat_Status { get; set; }
        public bool? Sold_Seat_Status { get; set; }
        public int? Row_Num { get; set; }
        public int? Col_Num { get; set; }
    }
}