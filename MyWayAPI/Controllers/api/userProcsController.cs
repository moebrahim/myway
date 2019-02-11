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
            var test = new Entities18();
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
                        ADD_TIME = pen.ADD_TIME,
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
            var con = new Entities15();
            var res = con.USERINVOICES(userID);
            foreach(var inv in res.ToList())
            {
                invres.Add(new USERINVOICES_Result
                {
                    DOC_ID = inv.DOC_ID,
                    DISTR = inv.DISTR,
                    DISTR_NAME = inv.DISTR_NAME,
                    COUNTER = inv.COUNTER,
                    ITEM_ID = inv.ITEM_ID,
                    ITEM_NAME = inv.ITEM_NAME,
                    PRICE = inv.PRICE,
                    QTY = inv.QTY,
                    NET_TOTAL = inv.NET_TOTAL,
                    ITEM_BP = inv.ITEM_BP,
                    TOTAL_BP = inv.TOTAL_BP,
                    DOC_DATE = inv.DOC_DATE,
                    DS_SHIPMENT = inv.DS_SHIPMENT,
                    SHIPMENT_STATUS = inv.SHIPMENT_STATUS,
                    DLV_DATE = inv.DLV_DATE,
                    COMP_NAME = inv.COMP_NAME

                });
            }
            return Ok(invres);
            //List<USERINVOICES_Result> invres = new List<USERINVOICES_Result>();
            //var con = new Entities13();
            //var res = con.USERINVOICES(userID).ToList();
            //foreach (var inv in res.ToList())
            //{
            //    invres.Add( new USERINVOICES_Result
            //    {
            //        DOC_ID = inv.DOC_ID,
            //        DISTR_ID = inv.DISTR_ID,
            //        DISTRNAME = inv.DISTRNAME,
            //        COUNTER = inv.COUNTER,
            //        ITEMNAME = inv.ITEMNAME,
            //        ITEM_ID = inv.ITEM_ID,
            //        PRICE = inv.PRICE,
            //        QTY = inv.QTY,
            //        NET_TOTAL= inv.NET_TOTAL,
            //        ITEM_BP = inv.ITEM_BP,
            //        TOTAL_BP = inv.TOTAL_BP,
            //        DLV_DATE = inv.DLV_DATE,
            //        SHIPMENT_STATUS = inv.SHIPMENT_STATUS,
            //        DOC_DATE = inv.DOC_DATE
            //    });

            //}
            //return Ok(invres);
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

        [Route("api/memberpromo/{distr_id}")]
        [HttpGet]
        public IHttpActionResult memberpromo(string distr_id)
        {
            List<MEMBERPROMO_Result> memp = new List<MEMBERPROMO_Result>();
            var con = new API_REPORTDBEntities1();
            var res = con.MEMBERPROMO(distr_id).ToList();
            foreach(var x in res.ToList())
            {
                memp.Add(new MEMBERPROMO_Result
                {
                    DISTR_ID = x.DISTR_ID,
                    BPA = x.BPA,
                    BPB = x.BPB,
                    BPC = x.BPC,
                    JOINPERIOD = x.JOINPERIOD
                });
            }
            return Ok(memp);
        }
    }
}