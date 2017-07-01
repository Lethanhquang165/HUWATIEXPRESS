using System.Web.Http;
using HUWATIExpress.Models;
using System.Linq;

namespace HUWATIExpress.Controllers.Mobile
{
    public class SeatMapForEachTripController : ApiController
    {
        huwadbDataContext db = new huwadbDataContext();

        ///<summary>
        /// SEATMAP FOR EACH TRIP, FILTER BY BUS_ID AND TRIP_ID
        /// LinK: /api/seatmapforeachtrip/seatmapfortrip?busId=1&tripId=1
        ///</summary>
        [HttpGet]
        public IQueryable<SeatMapForEachTripListItem> SeatMapForTrip (int busId, int tripId)
        {
            var subQuery1 = from bus in db.Bus
                            join seat in db.Seats on bus.Bus_Id equals seat.Bus_Id
                            where bus.Bus_Id == busId
                            select new
                            {
                                bus.Bus_Id,
                                seat.Seat_Code,
                                seat.Seat_Position,
                                seat.Status,
                                seat.Seat_Id,
                                bus.Row_Num,
                                bus.Col_Num
                            };

            var subQuery2 = from trip in db.Trips
                            join seatmap in db.Seat_Maps on trip.Trip_Id equals seatmap.Trip_Id
                            join seat in db.Seats on seatmap.Seat_Id equals seat.Seat_Id
                            where trip.Trip_Id == tripId
                            select new
                            {
                                trip.Bus_Id,
                                seatmap.Status,
                                seat.Seat_Id
                            };

            var listItem = from listItem1 in subQuery1
                           join listItem2 in subQuery2 on listItem1.Seat_Id equals listItem2.Seat_Id into leftjoinfunc
                           from leftjoin in leftjoinfunc.DefaultIfEmpty()
                           select new SeatMapForEachTripListItem
                           {
                               Bus_Id = listItem1.Bus_Id,
                               Seat_Code = listItem1.Seat_Code,
                               Seat_Position = listItem1.Seat_Position,
                               Available_Seat_Status = listItem1.Status,
                               Sold_Seat_Status = leftjoin.Status ? null : (bool?)false,
                               Row_Num = listItem1.Row_Num,
                               Col_Num = listItem1.Col_Num
                           };

            return listItem;
        }
    }
}