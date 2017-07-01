using System;

namespace HUWATIExpress.Models
{
    public class TripByPointsListItem
    {
        public int TripId { get; set; }
        public int BusId { get; set; }
        public string CompanyName { get; set; }
        public string Bus_Type_Name { get; set; }
        public string Start_Point { get; set; }
        public string Def_Point { get; set; }
        public DateTime Start_Date { get; set; }
        public TimeSpan Start_Time { get; set; }
        public decimal Price { get; set; }
        public int Empty_Seat_Num { get; set; }

    }
}