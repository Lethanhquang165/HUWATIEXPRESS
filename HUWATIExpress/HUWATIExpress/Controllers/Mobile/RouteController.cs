using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HUWATIExpress.Models;

namespace HUWATIExpress.Controllers.Mobile
{
    public class RouteController : ApiController
    {
        huwadbDataContext db = new huwadbDataContext();
        ///<summary>
        /// GET LIST OF START POINT
        /// </summary>
        
        public IQueryable<string> GetListOfStartPoints()
        {
            var listItem = from route in db.Routes select route.Start_Point;
            return listItem;
        }

        ///<summary>
        /// GET LIST OF DEFINITION POINT
        /// </summary>

        public IQueryable<string> GetListOfDefPoints()
        {
            var listItem = from route in db.Routes select route.Def_Point;
            return listItem;
        }

        ///<summary>
        /// GET LIST OF ROUTES
        /// </summary>

        public IQueryable<Route> GetListOfRoutes()
        {
            var listItem = from route in db.Routes select route;
            return listItem;
        }
    }
}