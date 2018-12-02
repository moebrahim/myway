using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MyWayAPI.Controllers.api
{
    public class shipmentcompaniesController : ApiController
    {
        private readonly DBC _ctx;
        public shipmentcompaniesController()
        {
            _ctx = new DBC();
        }

        [HttpGet]
        public IHttpActionResult getAllShipnebtCompanies()
        {

            return Ok(_ctx.Shipments.Select(w => new { w.DS_SHIPMENT_COMP, w.ANAME}));
        }
    }
}