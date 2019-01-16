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
    public class invoicecontrolController : ApiController
    {
        private readonly DBC _ctx;
        public invoicecontrolController()
        {
            _ctx = new DBC();
        }
        //delete
        //[Route("api/invoicecontrol_clear")]
        //[HttpDelete]
        //public IHttpActionResult deleteap()
        //{
        //    var AP = _ctx.APM.Where(w => w.DOC_ID.StartsWith("06")); //&& w.DOC_ID != "06000000");
        //    foreach (var x in AP)
        //    {
        //        _ctx.Entry(x).State = System.Data.Entity.EntityState.Deleted;
        //        //_ctx.SaveChanges();
        //    }
        //    _ctx.SaveChanges();
        //    var AQ = _ctx.AQD.Where(w => w.DOC_ID.StartsWith("06"));// && w.DOC_ID != "06000000");
        //    foreach (var x in AQ)
        //    {
        //        _ctx.Entry(x).State = System.Data.Entity.EntityState.Deleted;
        //        //_ctx.SaveChanges();
        //    }
        //    _ctx.SaveChanges();
        //    var AA = _ctx.AAD.Where(w => w.VOU_ID.StartsWith("06") && w.TRANS_TYPE == "ST_RS_RSO_O");
        //    foreach (var x in AA)
        //    {
        //        _ctx.Entry(x).State = System.Data.Entity.EntityState.Deleted;
        //        // _ctx.SaveChanges();
        //    }
        //    _ctx.SaveChanges();
        //    var A9 = _ctx.A9M.Where(w => w.VOU_ID.StartsWith("06") && w.TRANS_TYPE == "ST_RS_RSO_O");
        //    foreach (var x in A9)
        //    {
        //        _ctx.Entry(x).State = System.Data.Entity.EntityState.Deleted;
        //        //_ctx.SaveChanges();
        //    }
        //    _ctx.SaveChanges();
        //    //return Ok(x);
        //    return Ok("06 values for ACC011AP, ACC011AQ, ACC011A9, ACC011AA deleted.");
        //}
        //
        [Route("api/invoicecontrol_init")]
        [HttpPut]
        public IHttpActionResult initrows()
        {
            InvoiceDTO init = new InvoiceDTO
            {
                a9master = new ACC011A9
                {
                    VOU_ID = "06000000",
                    TRANS_TYPE = "ST_RS_RSO_O",
                    DS_SHIPMENT = "020006000000",
                    CUS_VEN_ID = "00000001",
                    S_SERIAL = "SA004Y82UF01Q29",
                    REC_OWNER = "U",
                    PRJ_ID = "00",
                    STORE_ID = "02",
                    BRANCH_ID = "02",
                    USE_RSRV = "0",
                    DOC_ID = "",
                    USER_ID = "006",
                    LAST_USER = "006",
                    COMP_ID = "001",
                    S_AUTO_KEY = 1,
                    V_DISTR_ID = "0000",
                    ADD_TIME = DateTime.UtcNow.ToString("HH:mm:ss")//AddHours(1).ToString("HH:mm:ss"),//+ DateTime.Parse("01:00:00"),//DateTime.Now.ToString("HH:mm:ss"),

                },
                apmaster = new ACC011AP
                {
                    DOC_ID = "06000000",
                    DS_SHIPMENT = "020006000000",
                    S_SERIAL = "SA0050JG911QH05",
                    REC_OWNER = "U",
                    //apmaster.DISTR_ID = inv.a9master.CUS_VEN_ID,
                    DOC_DATE = DateTime.UtcNow.ToString("yyy-MM-dd"),
                    SM_ID = "00",
                    SA_ID = "02",
                    SL_LOC_ID = "02",
                    DISC_RATIO = 0,
                    DISC_VAL = 0,
                    ADDED_TAX = 0,
                    DED_TAX = 0,
                    NET_AFTER_TAX = 0,
                    LDELIVERY = "0000000000",
                    // AREMARKS = "",
                    // LREMARKS = "",
                    IS_TEMPLATE = "0",
                    CLOSEDFLAG = "0",
                    ADD_TIME = DateTime.Now.ToString("HH:mm:ss"),
                    ADD_DATE = DateTime.Now.ToString("yyy-MM-dd"),
                    LAST_DATE = DateTime.Now.ToString("yyy-MM-dd"),
                    SENT = "0",
                    OWNER = null,
                    MODULE_ID = "SA",
                    HELD = "0",
                    PRJ_ID = null,
                    COMP_ID = "001",
                    USER_ID = "006",
                    LAST_USER = "006",
                    S_AUTO_KEY = 0,
                    //S_SERIAL = "SA0053A2LIZQH00",
                }
            };


            _ctx.A9M.Add(init.a9master);
            _ctx.APM.Add(init.apmaster);
            _ctx.SaveChanges();
            return Ok("Initial serialization values have been added.");
        }

    }
}