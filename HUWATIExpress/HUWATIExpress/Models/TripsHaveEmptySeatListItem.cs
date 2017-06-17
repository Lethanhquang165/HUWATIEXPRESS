using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HUWATIExpress.Models
{
    public class TripsHaveEmptySeatListItem
    {
        public int Trip_Id { get; set; }
        public int Bus_Id { get; set; }
        public string CompanyName { get; set; }
        public string Bus_Type_Name { get; set; }
        public string Start_Point { get; set; }
        public string Def_Point { get; set; }
        public DateTime Start_Date { get; set; }
        public TimeSpan Start_Time { get; set; }
        public int Empty_Seat_Sum { get; set; }
        public decimal Price { get; set; }
    }
}