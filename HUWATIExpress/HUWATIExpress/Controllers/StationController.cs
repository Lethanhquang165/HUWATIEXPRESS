using HUWATIExpress.Models;
using System.Linq;
using System.Web.Http;

namespace HUWATIExpress.Controllers
{
    public class StationController : ApiController
    {
        huwadbDataContext db = new huwadbDataContext();

        [HttpGet]
        public IQueryable<Stations> GetStationsList()
        {
            var data = from r in db.Routes
                       join t in db.Trips on r.Route_Id equals t.Route_Id
                       join st in db.Seat_Types on r.Seat_Type_Id equals st.Seat_Type_Id
                       select new Stations
                       {
                           Start_Point = r.Start_Point,
                           Def_Point = r.Def_Point,
                           Start_Time = t.Start_Time,
                           Type = st.Type,
                           Status = t.Status
                       };
            return data;
        }

        [HttpGet]
        public Stations GetStationById(int id)
        {
            var data = from r in db.Routes
                       join t in db.Trips on r.Route_Id equals t.Route_Id
                       join st in db.Seat_Types on r.Seat_Type_Id equals st.Seat_Type_Id
                       where r.Route_Id == id
                       select new Stations
                       {
                           Start_Point = r.Start_Point,
                           Def_Point = r.Def_Point,
                           Start_Time = t.Start_Time,
                           Type = st.Type,
                           Status = t.Status
                       };
            return data.FirstOrDefault();
        }
    }
}