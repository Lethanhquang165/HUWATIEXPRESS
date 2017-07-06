using HUWATIExpress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace HUWATIExpress.Controllers.Mobile
{
    public class TripController : ApiController
    {
        huwadbDataContext db = new huwadbDataContext();
        /// <summary>
        /// GET: LIST TRIP BY START POINT END DEF POINT
        /// Link: api/gettripbypoints/{startPoint}/{defPoint}/{startDate}
        /// </summary> 
        [HttpGet]
        public IQueryable<TripByPointsListItem> GetTripByPoints(string startPoint, string defPoint, DateTime startDate)
        {
            var emptyseatno = (from company in db.Companies

                               join bus in db.Bus on company.Company_Id equals bus.Company_Id
                               join bustype in db.Bus_Types on bus.Bus_Type_Id equals bustype.Bus_Type_Id
                               join trip in db.Trips on bus.Bus_Id equals trip.Bus_Id
                               join seatmap in db.Seat_Maps on trip.Trip_Id equals seatmap.Trip_Id
                               join seat in db.Seats on bus.Bus_Id equals seat.Bus_Id
                               join route in db.Routes on trip.Route_Id equals route.Route_Id

                               where route.Start_Point == startPoint && route.Def_Point == defPoint && trip.Start_Date == startDate && seatmap.Status == false
                               select seat.Bus_Id).Count();

              var listItem =  from company in db.Companies

                            join bus in db.Bus on company.Company_Id equals bus.Company_Id
                            join bustype in db.Bus_Types on bus.Bus_Type_Id equals bustype.Bus_Type_Id
                            join trip in db.Trips on bus.Bus_Id equals trip.Bus_Id
                            join route in db.Routes on trip.Route_Id equals route.Route_Id
                      
                            where route.Start_Point == startPoint && route.Def_Point == defPoint && trip.Start_Date == startDate
                            select new TripByPointsListItem
                            {
                                TripId = trip.Trip_Id,
                                BusId = bus.Bus_Id,
                                CompanyName = company.Company_Name,
                                Bus_Type_Name = bustype.Bus_Type_Name,
                                Start_Point = route.Start_Point,
                                Def_Point = route.Def_Point,
                                Start_Date = trip.Start_Date,
                                Start_Time = trip.Start_Time,
                                Price = trip.Price,
                                Empty_Seat_Num = emptyseatno
                            };
            return listItem;
        }

        /// <summary>
        /// GET: LIST TRIP HAVE EMPTY SEAT
        /// Link: api/getlistoftriphavemptyseat
        /// </summary> 
        [HttpGet]
        public IQueryable<TripsHaveEmptySeatListItem> GetListOfTripHaveEmptySeat()
        {
            ///<summary>
            ///Select	s.Seat_Id, t.Trip_Id
            ///From Bus b, Seat s, Trip t
            ///Where    b.Bus_Id = s.Bus_Id and
            ///         t.Bus_Id = b.Bus_Id and
            ///         s.Status = 1
            ///         EXCEPT
            ///         Select sm.Seat_Id, t.Trip_Id
            ///         From Trip t, Seat_Map sm
            ///         Where t.Trip_Id = sm.Trip_Id and sm.Status = 1
            ///	)       as subItem1st
            ///</summary>

            var subItem1st = from seat in db.Seats

                             join bus in db.Bus on seat.Bus_Id equals bus.Bus_Id
                             join trip in db.Trips on bus.Bus_Id equals trip.Bus_Id

                             select new AvailableSeatByTripListItem
                             {
                                 Seat_Id = seat.Seat_Id,
                                 Trip_Id = trip.Trip_Id,
                                 Bus_Id = bus.Bus_Id,
                             };

            ///<summary>
            ///Select Count(s.Seat_Id) as [Seat Trống], s.Trip_Id
            ///From subItem1 
            ///Group By s.Trip_Id as subItem2nd
            ///</summary>
            var subItem2nd = from items in subItem1st
                             group items by items.Trip_Id into g
                             select new { g.Key, g };

            ///<summary>
            ///
            ///</summary>

            var listItem = from trip in db.Trips

                           join bus in db.Bus on trip.Bus_Id equals bus.Bus_Id
                           join company in db.Companies on bus.Company_Id equals company.Company_Id
                           join busType in db.Bus_Types on bus.Bus_Type_Id equals busType.Bus_Type_Id
                           join route in db.Routes on trip.Route_Id equals route.Route_Id
                           join items in subItem2nd on trip.Trip_Id equals items.Key

                           select new TripsHaveEmptySeatListItem
                           {
                               Trip_Id = trip.Trip_Id,
                               Bus_Id = bus.Bus_Id,
                               Bus_Type_Name = busType.Bus_Type_Name,
                               CompanyName = company.Company_Name,
                               Start_Point = route.Start_Point,
                               Def_Point = route.Def_Point,
                               Start_Date = trip.Start_Date,
                               Start_Time = trip.Start_Time,
                               Price = trip.Price,
                               Empty_Seat_Sum = items.g.Select(x => x.Seat_Id).Count()
                           };

            return listItem;
        }

        ///<summary>
        /// GET: LIST TRIP HAVE EMPTY SEAT BY START_DATE
        /// Link: api/getlistoftriphavemptyseatbystartdate
        ///</summary>
        [HttpGet]
        public IQueryable<TripsHaveEmptySeatListItem> GetListOfTripHaveEmptySeatByStartDate(DateTime startDay)
        {
            ///<summary>
            ///Select	s.Seat_Id, t.Trip_Id
            ///From Bus b, Seat s, Trip t
            ///Where    b.Bus_Id = s.Bus_Id and
            ///         t.Bus_Id = b.Bus_Id and
            ///         s.Status = 1
            ///         EXCEPT
            ///         Select sm.Seat_Id, t.Trip_Id
            ///         From Trip t, Seat_Map sm
            ///         Where t.Trip_Id = sm.Trip_Id and sm.Status = 1
            ///	)       as subItem1st
            ///</summary>

            var subItem1st = from seat in db.Seats

                             join bus in db.Bus on seat.Bus_Id equals bus.Bus_Id
                             join trip in db.Trips on bus.Bus_Id equals trip.Bus_Id

                             select new AvailableSeatByTripListItem
                             {
                                 Seat_Id = seat.Seat_Id,
                                 Trip_Id = trip.Trip_Id,
                                 Bus_Id = bus.Bus_Id,
                             };

            ///<summary>
            ///Select Count(s.Seat_Id) as [Seat Trống], s.Trip_Id
            ///From subItem1 
            ///Group By s.Trip_Id as subItem2nd
            ///</summary>
            var subItem2nd = from items in subItem1st
                             group items by items.Trip_Id into g
                             select new { g.Key, g };

            ///<summary>
            ///
            ///</summary>

            var listItem = from trip in db.Trips

                           join bus in db.Bus on trip.Bus_Id equals bus.Bus_Id
                           join company in db.Companies on bus.Company_Id equals company.Company_Id
                           join busType in db.Bus_Types on bus.Bus_Type_Id equals busType.Bus_Type_Id
                           join route in db.Routes on trip.Route_Id equals route.Route_Id
                           join items in subItem2nd on trip.Trip_Id equals items.Key

                           where trip.Start_Date == startDay

                           select new TripsHaveEmptySeatListItem
                           {
                               Trip_Id = trip.Trip_Id,
                               Bus_Id = bus.Bus_Id,
                               Bus_Type_Name = busType.Bus_Type_Name,
                               CompanyName = company.Company_Name,
                               Start_Point = route.Start_Point,
                               Def_Point = route.Def_Point,
                               Start_Date = trip.Start_Date,
                               Start_Time = trip.Start_Time,
                               Price = trip.Price,
                               Empty_Seat_Sum = items.g.Select(x => x.Seat_Id).Count()
                           };

            return listItem;
        }
    }
}