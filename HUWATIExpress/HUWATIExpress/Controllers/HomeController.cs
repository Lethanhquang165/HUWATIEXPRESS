using HUWATIExpress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace HUWATIExpress.Controllers
{
    public class HomeController : ApiController
    {
        huwadbDataContext db = new huwadbDataContext();

        [HttpGet]
        public IEnumerable<Route> GetRoutesLists()
        {
            return db.Routes.ToList();
        }

        [HttpGet]
        public Route GetRouteById(int id)
        {
            return db.Routes.FirstOrDefault(x => x.Route_Id == id);
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
        public IEnumerable<Trip> GetTripsLists()
        {
            return db.Trips.ToList();
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

        [HttpPut]
        public bool UpdateTrip(int id, int routeid, DateTime starttime, DateTime endtime, bool status)
        {
            try
            {
                Trip trip = db.Trips.FirstOrDefault(x => x.Trip_Id == id);
                if (trip == null) return false;
                trip.Route_Id = routeid;
                trip.Start_Time = starttime;
                trip.End_Time = endtime;
                trip.Status = status;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpDelete]
        public bool DeleteTrip(int id)
        {
            Trip trip = db.Trips.FirstOrDefault(x => x.Trip_Id == id);
            if (trip == null) return false;
            db.Trips.DeleteOnSubmit(trip);
            db.SubmitChanges();
            return true;
        }
    }
}
