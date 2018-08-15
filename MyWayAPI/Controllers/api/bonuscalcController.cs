using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MyWayAPI.Controllers.api
{
    public class bonuscalcController : ApiController
    {
        private readonly DBC _ctx;
        public bonuscalcController()
        {
            _ctx = new DBC();
        }

        //[HttpGet]
        //public IHttpActionResult getbonus(string id)
        //{
        //    var x = 
        //    return Ok();
        //}
    }
}