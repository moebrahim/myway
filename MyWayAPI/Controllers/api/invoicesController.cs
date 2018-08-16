using MyWayAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MyWayAPI.Controllers.api
{
    public class invoicesController : ApiController
    {
        [Route("api/invoices/{id}")]
        [HttpGet]
        public IHttpActionResult getinvoices (string id)
        {
            List<INVOICE_Result> pendinglist = new List<INVOICE_Result>();
            var test = new Entities2();
            var reslist = test.INVOICE(id).ToList();
            foreach (var pen in reslist.ToList())
            {
                pendinglist.Add(
                    new INVOICE_Result
                    {
                        DOC_ID = pen.DOC_ID,
                        ITEM_ID = pen.ITEM_ID,
                        ANAME = pen.ANAME,
                        COUNTER = pen.COUNTER,
                        QTY = pen.QTY,
                        PRICE = pen.PRICE,
                        NET_TOTAL = pen.NET_TOTAL,
                        ITEM_BP = pen.ITEM_BP,
                        TOTAL_BP = pen.TOTAL_BP,
                        DOC_DATE = pen.DOC_DATE
                    }
                    );
            }
            return Ok(pendinglist);
        }
    }
}