using HUWATIExpress.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;

namespace HUWATIExpress.Controllers
{
    public class StationController : ApiController
    {
        huwadbDataContext db = new huwadbDataContext();

        [HttpGet]
        public IQueryable<Station> GetStationsList()
        {
            return db.Stations;
        }

        [HttpGet]
        public Station GetStationById(int id)
        {
            return db.Stations.Where(t => t.Station_Id == id).SingleOrDefault();
        }
    }
}