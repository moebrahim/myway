using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MyWayAPI.Controllers.api
{
    public class shipmentareaController : ApiController
    {
        private readonly DBC _ctx;
        public shipmentareaController()
        {
            _ctx = new DBC();
        }
        [Route("api/getshipment/")]
        [HttpGet]
        public IHttpActionResult gettable()
        {
            return Ok(_ctx.ShipmentPlace.Select(x => new { x.DS_SHIPMENT_PLACE, x.ANAME }));
        }
        [Route("api/getshipmentbyplaceid/{dsShipment}")]
        [HttpGet]
        public IHttpActionResult getbyplaceID(string dsShipment)
        {
            return Ok(_ctx.ShipmentPlace.Select(w=> new { w.DS_SHIPMENT_PLACE, w.ANAME }).Where(x=>x.DS_SHIPMENT_PLACE == dsShipment));
        }
        [Route("api/getshipmentbyaname/{aname}")]
        [HttpGet]
        public IHttpActionResult getbyAname(string aname)
        {
            return Ok(_ctx.ShipmentPlace.Select(w => new { w.DS_SHIPMENT_PLACE, w.ANAME }).Where(x => x.ANAME == aname));
        }
    }
}