using HUWATIExpress.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Runtime.Serialization;

namespace HUWATIExpress.Controllers
{
    [DataContract(IsReference = true)]
    public class RouteController : ApiController
    {
        huwadbDataContext db = new huwadbDataContext();
        [HttpGet]
        public IEnumerable<Route> GetRoutesList()
        {
            return db.Routes.ToList();
        }

        [HttpGet]
        public Route GetRouteById(int id)
        {
            return db.Routes.Where(t => t.Route_Id == id).SingleOrDefault();
        }
    }
}
