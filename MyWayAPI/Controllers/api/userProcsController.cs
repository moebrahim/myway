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
    public class userProcsController : ApiController
    {
        [Route("api/userpending/{userID}")]
        [HttpGet]
        public IHttpActionResult userpending(string userID)
        {
            List<USERPENDING_Result> userPendingRes = new List<USERPENDING_Result>();
            var test = new Entities7();
            var reslist = test.USERPENDING(userID).ToList();
            foreach (var pen in reslist.ToList())
            {
                userPendingRes.Add(
                    new USERPENDING_Result
                    {
                        DOC_ID = pen.DOC_ID,
                        DISTR_ID = pen.DISTR_ID,
                        DISTRNAME = pen.DISTRNAME,
                        COUNTER = pen.COUNTER,
                        ITEM_ID = pen.ITEM_ID,
                        ITEMNAME = pen.ITEMNAME,
                        QTY_REQ = pen.QTY_REQ,
                        UNIT_PRICE = pen.UNIT_PRICE,
                        TOT_PRICE = pen.TOT_PRICE,
                        ITEM_BP = pen.ITEM_BP,
                        TOTAL_BP = pen.TOTAL_BP,
                        DOC_DATE = pen.DOC_DATE
                    });
            }
            return Ok(userPendingRes);
        }

        [Route("api/userinvoices/{userID}")]
        [HttpGet]
        public IHttpActionResult userInvoices(string userID)
        {
            List<USERINVOICES_Result> invres = new List<USERINVOICES_Result>();
            var con = new Entities8();
            var res = con.USERINVOICES(userID).ToList();
            foreach (var inv in res.ToList())
            {
                invres.Add( new USERINVOICES_Result
                {
                    DOC_ID = inv.DOC_ID,
                    DISTR_ID = inv.DISTR_ID,
                    DISTRNAME = inv.DISTRNAME,
                    COUNTER = inv.COUNTER,
                    ITEMNAME = inv.ITEMNAME,
                    ANAME = inv.ANAME,
                    PRICE = inv.PRICE,
                    QTY = inv.QTY,
                    NET_TOTAL= inv.NET_TOTAL,
                    ITEM_BP = inv.ITEM_BP,
                    TOTAL_BP = inv.TOTAL_BP,
                    DOC_DATE = inv.DOC_DATE
                });

            }
            return Ok(invres);
        }

        [Route("api/pendingmember/{userID}")]
        [HttpGet]
        public IHttpActionResult pendingmem(string userID)
        {
            List<PENDINGMEMBER_Result> invres = new List<PENDINGMEMBER_Result>();
            var con = new Entities10();
            var res = con.PENDINGMEMBER(userID).ToList();
            foreach (var inv in res.ToList())
            {
                invres.Add( new PENDINGMEMBER_Result
                {
                    DOC_ID = inv.DOC_ID,
                    DISTR_ID = inv.DISTR_ID,
                    ANAME = inv.ANAME,
                    TOT_PRICE = inv.TOT_PRICE,
                    DOC_DATE = inv.DOC_DATE
                    
                });
            }
                return Ok(invres);
        }

    }
}