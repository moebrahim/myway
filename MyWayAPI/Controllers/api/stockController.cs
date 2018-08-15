using MyWayAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MyWayAPI.Controllers.api
{
    public class stockController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetStock(string id)
        {
            List<liveStock> stocks = new List<liveStock>();
            using (DBC contxt = new DBC())
            {
                var result = from a in contxt.Stock
                             where a.itemId == id
                             select a;
                foreach (var item in result)
                {
                    stocks.Add(new liveStock
                    {
                        qty = item.qty,
                        itemId = item.itemId

                    }
                        );

                }
            }
            return Ok(stocks);

        }
    }
}
