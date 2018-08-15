using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MyWayAPI.Controllers.api
{
    public class areaController : ApiController
    {
        private readonly DBC _ctx;
        public areaController()
        {
            _ctx = new DBC();
        }
        [Route("api/areas")]
        [HttpGet]
        public IHttpActionResult getallareanames()
        {
            var q = _ctx.Area.Select(x => new { x.ANAME, x.AREA_ID });
            return Ok(q);
        }

        [Route("api/areaname/{name}")]
        [HttpGet]
        public IHttpActionResult getbyname(string name)
        {

           return Ok(_ctx.Area.Select(x => new { x.ANAME, x.AREA_ID }).Where(w=>w.ANAME == name));
        }

        [Route("api/areaid/{id}")]
        [HttpGet]
        public IHttpActionResult getbyid (string id)
        {
            return Ok(_ctx.Area.Select(x => new { x.ANAME, x.AREA_ID }).Where(w => w.AREA_ID == id));
        }
    }
}