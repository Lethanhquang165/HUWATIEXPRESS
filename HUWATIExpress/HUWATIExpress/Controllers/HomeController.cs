using HUWATIExpress.Models;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System;
using System.Runtime.Serialization;

namespace HUWATIExpress.Controllers
{
    [DataContract(IsReference = true)]
    public class RouteController : ApiController
    {
        huwadbDataContext db = new huwadbDataContext { ObjectTrackingEnabled = true };
        [HttpGet]
        public IEnumerable<Route> GetRoutesLists()
        {
            return db.Routes.ToList();
        }

        [HttpGet]
        public Route GetRouteById(int id)
        {
            return db.Routes.Where(t => t.Route_Id == id).Include(t => t.Trips).SingleOrDefault();
        }

        [HttpPost]
        public bool InsertNewRoute(string description, string url)
        {
            try
            {
                var rt = new Route();
                rt.Description = description;
                rt.Photo = url;
                db.Routes.InsertOnSubmit(rt);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpPut]
        public bool UpdateRoute(int id, string description, string url)
        {
            try
            {
                Route rt = db.Routes.FirstOrDefault(x => x.Route_Id == id);
                if (rt == null) return false;
                rt.Description = description;
                rt.Photo = url;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpDelete]
        public bool DeleteRoute(int id)
        {
            Route rt = db.Routes.FirstOrDefault(x => x.Route_Id == id);
            if (rt == null) return false;
            db.Routes.DeleteOnSubmit(rt);
            db.SubmitChanges();
            return true;
        }
    }
    public class TripController : ApiController
    {
        huwadbDataContext db = new huwadbDataContext();

        [HttpGet]
        public IQueryable<Trip> GetTripsLists()
        {
            return db.Trips.Include(t => t.Route);
        }

        [HttpGet]
        public Trip GetTripById(int id)
        {
            return db.Trips.FirstOrDefault(x => x.Trip_Id == id);
        }

        [HttpPost]
        public bool InsertNewTrip(int routeid, DateTime starttime, DateTime endtime, bool status)
        {
            try
            {
                var trip = new Trip();
                var route = new Route();
                routeid = route.Route_Id;
                trip.Route_Id = routeid;
                trip.Start_Time = starttime;
                trip.End_Time = endtime;
                trip.Status = status;
                db.Trips.InsertOnSubmit(trip);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

        //    [HttpPut]
        //    public bool UpdateTrip(int id, int routeid, DateTime starttime, DateTime endtime, bool status)
        //    {
        //        try
        //        {
        //            Trip trip = db.Trips.FirstOrDefault(x => x.Trip_Id == id);
        //            if (trip == null) return false;
        //            trip.Route_Id = routeid;
        //            trip.Start_Time = starttime;
        //            trip.End_Time = endtime;
        //            trip.Status = status;
        //            db.SubmitChanges();
        //            return true;
        //        }
        //        catch
        //        {
        //            return false;
        //        }
        //    }

        //    [HttpDelete]
        //    public bool DeleteTrip(int id)
        //    {
        //        Trip trip = db.Trips.FirstOrDefault(x => x.Trip_Id == id);
        //        if (trip == null) return false;
        //        db.Trips.DeleteOnSubmit(trip);
        //        db.SubmitChanges();
        //        return true;
        //    }
        //}
        //public class Seat_TypeController : ApiController
        //{
        //    huwadbDataContext db = new huwadbDataContext();

        //    [HttpGet]
        //    public IEnumerable<Seat_Type> GetSeat_TypesList()
        //    {
        //        return db.Seat_Types.ToList();
        //    }

        //    [HttpGet]
        //    public Seat_Type GetSeat_TypeById(int id)
        //    {
        //        return db.Seat_Types.FirstOrDefault(x => x.Seat_Type_Id == id);
        //    }

        //    [HttpPost]
        //    public bool InsertNewSeat_Type(string type)
        //    {
        //        try
        //        {
        //            var rt = new Seat_Type();
        //            rt.Type = type;
        //            db.Seat_Types.InsertOnSubmit(rt);
        //            db.SubmitChanges();
        //            return true;
        //        }
        //        catch
        //        {
        //            return false;
        //        }
        //    }

        //    [HttpPut]
        //    public bool UpdateSeat_Type(int id, string type)
        //    {
        //        try
        //        {
        //            Seat_Type rt = db.Seat_Types.FirstOrDefault(x => x.Seat_Type_Id == id);
        //            if (rt == null) return false;
        //            rt.Type = type;
        //            db.SubmitChanges();
        //            return true;
        //        }
        //        catch
        //        {
        //            return false;
        //        }
        //    }

        //    [HttpDelete]
        //    public bool DeleteSeat_Type(int id)
        //    {
        //        Seat_Type rt = db.Seat_Types.FirstOrDefault(x => x.Seat_Type_Id == id);
        //        if (rt == null) return false;
        //        db.Seat_Types.DeleteOnSubmit(rt);
        //        db.SubmitChanges();
        //        return true;
        //    }
        //}
        //public class SeatController : ApiController
        //{
        //    huwadbDataContext db = new huwadbDataContext();

        //    [HttpGet]
        //    public IEnumerable<Seat> GetSeatLists()
        //    {
        //        return db.Seats.ToList();
        //    }

        //    [HttpGet]
        //    public Seat GetSeatById(int id)
        //    {
        //        return db.Seats.FirstOrDefault(x => x.Seat_Id == id);
        //    }

        //    [HttpPost]
        //    public bool InsertNewSeat(int seat_type_id, long status)
        //    {
        //        try
        //        {
        //            var rt = new Seat();
        //            var st = new Seat_Type();
        //            rt.Status = status;
        //            rt.Seat_Type_Id = st.Seat_Type_Id;
        //            db.Seats.InsertOnSubmit(rt);
        //            db.SubmitChanges();
        //            return true;
        //        }
        //        catch
        //        {
        //            return false;
        //        }
        //    }

        //    [HttpPut]
        //    public bool UpdateSeat(int id, int seat_type_id, long status)
        //    {
        //        try
        //        {
        //            Seat rt = db.Seats.FirstOrDefault(x => x.Seat_Id == id);
        //            if (rt == null) return false;
        //            var st = new Seat_Type();
        //            rt.Seat_Type_Id = st.Seat_Type_Id;
        //            rt.Status = status;
        //            db.SubmitChanges();
        //            return true;
        //        }
        //        catch
        //        {
        //            return false;
        //        }
        //    }

        //    [HttpDelete]
        //    public bool DeleteSeat(int id)
        //    {
        //        Seat rt = db.Seats.FirstOrDefault(x => x.Seat_Id == id);
        //        if (rt == null) return false;
        //        db.Seats.DeleteOnSubmit(rt);
        //        db.SubmitChanges();
        //        return true;
        //    }
        //}
        //public class TicketController : ApiController
        //{
        //    huwadbDataContext db = new huwadbDataContext();

        //    [HttpGet]
        //    public IEnumerable<Ticket> GetTicketLists()
        //    {
        //        return db.Tickets.ToList();
        //    }

        //    [HttpGet]
        //    public Ticket GetTicketById(int id)
        //    {
        //        return db.Tickets.FirstOrDefault(x => x.Ticket_Id == id);
        //    }

        //    [HttpPost]
        //    public bool InsertNewTicket(int busid, int tripid, int seatid, bool status, int customerid, decimal unitprice)
        //    {
        //        try
        //        {
        //            var ticket = new Ticket();
        //            var bus = new Bus();
        //            bus.Bus_Id = busid;
        //            var trip = new Trip();
        //            trip.Trip_Id = tripid;
        //            var seat = new Seat();
        //            seat.Seat_Id = seatid;

        //            ticket.Status = status;
        //            ticket.Bus_Id = busid;
        //            ticket.Trip_Id = tripid;
        //            ticket.Seat_Id = seatid;
        //            ticket.Customer_Id = customerid;
        //            ticket.Unit_Price = unitprice;

        //            db.Tickets.InsertOnSubmit(ticket);
        //            db.SubmitChanges();
        //            return true;
        //        }
        //        catch
        //        {
        //            return false;
        //        }
        //    }

        //    [HttpPut]
        //    public bool UpdateTicket(int id, int busid, int tripid, int seatid, bool status, int customerid, decimal unitprice)
        //    {
        //        try
        //        {
        //            Ticket rt = db.Tickets.FirstOrDefault(x => x.Ticket_Id == id);

        //            if (rt == null) return false;

        //            var ticket = new Ticket();
        //            var bus = new Bus();
        //            bus.Bus_Id = busid;
        //            var trip = new Trip();
        //            trip.Trip_Id = tripid;
        //            var seat = new Seat();
        //            seat.Seat_Id = seatid;

        //            ticket.Status = status;
        //            ticket.Bus_Id = busid;
        //            ticket.Trip_Id = tripid;
        //            ticket.Seat_Id = seatid;
        //            ticket.Customer_Id = customerid;
        //            ticket.Unit_Price = unitprice;

        //            db.SubmitChanges();
        //            return true;
        //        }
        //        catch
        //        {
        //            return false;
        //        }
        //    }

        //    [HttpDelete]
        //    public bool DeleteTicket(int id)
        //    {
        //        Ticket rt = db.Tickets.FirstOrDefault(x => x.Ticket_Id == id);
        //        if (rt == null) return false;
        //        db.Tickets.DeleteOnSubmit(rt);
        //        db.SubmitChanges();
        //        return true;
        //    }
        //}
