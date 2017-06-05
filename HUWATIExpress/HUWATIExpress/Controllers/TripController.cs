using HUWATIExpress.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;

namespace HUWATIExpress.Controllers
{
    public class TripController : ApiController
    {
        huwadbDataContext db = new huwadbDataContext();

        [HttpGet]
        public IQueryable<Trip> GetTripsList()
        {
            return db.Trips;
        }

        [HttpGet]
        public Trip GetTripById(int id)
        {
            return db.Trips.Where(t => t.Trip_Id == id).SingleOrDefault();
        }
    }
}