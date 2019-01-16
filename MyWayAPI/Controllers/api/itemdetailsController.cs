using MyWayAPI.ConvertBase36;
using MyWayAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace MyWayAPI.Controllers.api
{
    public class itemdetailsController : ApiController
    {
        private readonly DBC _ctx;
        public itemdetailsController ()
        {
            _ctx = new DBC();
        }
        //GET/api/products/1
        [Route("api/itemdetails/{itemID}")]
        [HttpGet]
        public IHttpActionResult getitemdetails(string itemID)
        {

            return Ok(_ctx.Products.Select(w => new { w.ITEM_ID, w.ANAME, w.PRICE, w.PROMO, w.BP, w.BV, w.CATALOG, w.DISCONTINUED, w.NEW, w.WEIGHT, w.WEIGHT_UNIT, w.ENABLED }).Where(q => q.ITEM_ID == itemID));
        }
        [Route("api/allitemdetails")]
        [HttpGet]
        public IHttpActionResult getallproducts()
        {
            return Ok(_ctx.Products.Select(w => new { w.ITEM_ID, w.ANAME, w.PRICE, w.PROMO, w.BP, w.BV, w.CATALOG, w.DISCONTINUED, w.NEW, w.WEIGHT, w.WEIGHT_UNIT, w.ENABLED }));
        }

        [Route("api/newproducts")]
        [HttpGet]
        public IHttpActionResult getallnewproducts()
        {

            return Ok(_ctx.Products.Select(w => new  { w.ITEM_ID, w.ANAME, w.PROMO, w.BP, w.BV, w.CATALOG, w.DISCONTINUED, w.NEW, w.WEIGHT, w.WEIGHT_UNIT, w.ENABLED}).Where(q=>q.NEW == true));
        }
    }
}