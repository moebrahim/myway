using MyWayAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MyWayAPI.Controllers.api
{
    public class invoiceController : ApiController
    {
        private readonly DBC _ctx;
        public invoiceController()
        {
            _ctx = new DBC();
        }
        [HttpGet]
        public IHttpActionResult getshit()
        {
            //impliment later
            return Ok("OK!");
        }
        [Route("api/editvou/{doc_id}/{distr_id}")]
        [HttpPost]
        public IHttpActionResult editVou (string doc_id,string distr_id)
        {
            var x = new CLOUD_COORDINATOREntities1();
            var res = x.EditVou(doc_id, distr_id);
            //x.
            //Console.WriteLine(res);
            //var xw = res;
            //if (res == "DELETED")
            //    return Ok("Docs are deleted");
            //else
            //    return Ok("Docs not found");
            return Ok(res);
        }




        [Route("api/invoice")]
        [HttpPut]
        //amr el bee3 8 fatoora 10
        //06
        public IHttpActionResult NewOrder (InvoiceDTO inv)
        {
            #region basic init
            //doing the acc011a9 first
            string vouIDplus = _ctx.A9M.Where(w => w.VOU_ID.StartsWith("06")).Where(x => x.TRANS_TYPE == "ST_RS_RSO_O").Max(q => q.VOU_ID);
            string vouSub = vouIDplus.Substring(2, vouIDplus.Length - 2);
            int vouSubInt = 0;
            if (int.TryParse(vouSub, out vouSubInt))
            {
                vouSubInt++;
                vouIDplus = vouSubInt.ToString();
                vouIDplus = vouIDplus.PadLeft(vouSub.Length, '0');
                vouIDplus = vouIDplus.Insert(0, "06");
            }
            //string shipment = _ctx.APM.Where(w => w.DS_SHIPMENT.StartsWith("020006")).Max(q => q.DS_SHIPMENT);
            string shipment = _ctx.APM.Where(w => w.DS_SHIPMENT.StartsWith("020006")).Where(q => q.DOC_ID.StartsWith("06")).Max(q => q.DS_SHIPMENT);
            shipment = shipment.Substring(shipment.Length - 6);
            int intshipment = 0;
            if(int.TryParse(shipment, out intshipment))
            {
                intshipment++;
                shipment = intshipment.ToString();
                shipment = shipment.PadLeft(6, '0');
            }
            #endregion
            //inv.a9master = new ACC011A9();
            #region ACC011A9
            inv.a9master.VOU_ID = vouIDplus;
            inv.a9master.TRANS_TYPE = "ST_RS_RSO_O";
            inv.a9master.VOU_DATE = inv.a9master.ADD_DATE = inv.a9master.LAST_DATE = DateTime.Now.ToString("yyy-MM-dd");
            //adescr is ""
            inv.a9master.ADESCR = "";
            inv.a9master.LDESCR = "";
            inv.a9master.PRJ_ID = "00";
            //make sure it's 06
            inv.a9master.STORE_ID = "02";
            inv.a9master.TO_ST_ID = "";
            //inv.a9master.CUS_VEN_ID distr_id .. input
            inv.a9master.BRANCH_ID = "02";
            inv.a9master.DOC_ID = "";
            inv.a9master.USE_RSRV = "0";
            inv.a9master.PERIOD_NO = Convert.ToDouble(_ctx.Periods.Where(w => w.MODULE_ID == "SA").Select(x => x.LAST_OPEN).SingleOrDefault());
            inv.a9master.TOTAL_COST = 0;
            inv.a9master.POSTED = "0";
            inv.a9master.NO_MODIFY = "0";
            
            inv.a9master.SENT = "0";
            inv.a9master.MODULE_ID = "SA";
            //inv.a9master.USER_ID = inv.a9master.LAST_USER = "006";
            inv.a9master.COMP_ID = "001";
            inv.a9master.S_AUTO_KEY = 1;
            inv.a9master.V_DISTR_ID = "0000";
            inv.a9master.ADD_TIME = DateTime.UtcNow.ToString("HH:mm:ss");//AddHours(1).ToString("HH:mm:ss");//+ DateTime.Parse("01:00:00");//DateTime.Now.ToString("HH:mm:ss");
            inv.a9master.S_SERIAL = "SA0053A2LIZQH00";
            inv.a9master.REC_OWNER = "U";
            //inv.a9master.DS_SHIPMENT = "020006" + shipment;
            #endregion

            #region basic init 2
            vouIDplus = _ctx.APM.Where(w => w.DOC_ID.StartsWith("06")).Max(q => q.DOC_ID);
            vouSub = vouIDplus.Substring(2, vouIDplus.Length - 2);
            vouSubInt = 0;
            if (int.TryParse(vouSub, out vouSubInt))
            {
                vouSubInt++;
                vouIDplus = vouSubInt.ToString();
                vouIDplus = vouIDplus.PadLeft(vouSub.Length, '0');
                vouIDplus = vouIDplus.Insert(0, "06");
            }
            #endregion

            #region ACC011AP
            //gross_total & net_total
            //inv.apmaster = new ACC011AP();
            inv.apmaster.DOC_ID = vouIDplus;
            inv.apmaster.QUOT_ID = inv.a9master.VOU_ID;
            inv.apmaster.DISTR_ID = inv.a9master.CUS_VEN_ID;
            inv.apmaster.DOC_DATE = DateTime.UtcNow.ToString("yyy-MM-dd");
            inv.apmaster.SM_ID = "00";
            inv.apmaster.SA_ID = "02";
            inv.apmaster.SL_LOC_ID = "02";
            inv.apmaster.DISC_RATIO = 0;
            inv.apmaster.DISC_VAL = 0;
            inv.apmaster.ADDED_TAX = 0;
            inv.apmaster.DED_TAX = 0;
            inv.apmaster.NET_AFTER_TAX = 0;
            inv.apmaster.LDELIVERY = "0000000000";
            //inv.apmaster.AREMARKS = "";
            //inv.apmaster.LREMARKS = "";
            inv.apmaster.IS_TEMPLATE = "0";
            inv.apmaster.CLOSEDFLAG = "0";
            inv.apmaster.ADD_TIME = DateTime.Now.ToString("HH:mm:ss");
            inv.apmaster.ADD_DATE = inv.apmaster.LAST_DATE = DateTime.Now.ToString("yyy-MM-dd");
            inv.apmaster.SENT = "0";
            inv.apmaster.OWNER = null;
            inv.apmaster.MODULE_ID = "SA";
            inv.apmaster.HELD = "0";
            inv.apmaster.PRJ_ID = null;
            inv.apmaster.COMP_ID = "001";
            inv.apmaster.USER_ID = inv.apmaster.LAST_USER = inv.a9master.USER_ID;
            inv.apmaster.S_AUTO_KEY = 0;
            inv.apmaster.S_SERIAL = inv.a9master.CUS_VEN_ID + inv.apmaster.DOC_ID;
            //inv.apmaster.DISC_NOTES = "";
            //inv.apmaster.DS_SHIPMENT = "60" + inv.a9master.CUS_VEN_ID;
            //inv.apmaster.DS_SHIPMENT = inv.a9master.DS_SHIPMENT;
            #endregion
            #region //stuff to ask about and old code
            //inv.apmaster.DS_SHIPMENT_PLACE = ""; idk 
            //inv.apmaster.REC_OWNER = "U"; could be null
            //inv.apmaster.CLOSEDFLAG = null; //takes null, 0, 1 idk the reason
            //inv.apmaster.IS_TEMPLATE = inv.apmaster.CUST_ID = inv.apmaster.STORE_ID = inv.apmaster.EXP_DLV_DATE = inv.apmaster.RSRV_ID = inv.apmaster.CLOSE_LEVEL = inv.apmaster.ST_CLOSED = null;
            //inv.apmaster.DS_SHIPMENT = NULL //mostly takes NULL
            //inv.apmaster.DS_SHIPMENT_COMP = NULL //mostly takes NULL
            //inv.apmaster.DS_SHIPMENT_COMP
            //the acc011aa
            //List<ACC011AA> ad = new List<ACC011AA>{new ACC011AA{ VOU_ID = inv.a9master.VOU_ID, TRANS_TYPE = "ST_RS_RSO_O" } };            
            //using (_ctx)
            //{              
            //    foreach (ACC011AA aadetail in ad)
            //    {                   
            //        _ctx.AAD.Add(aadetail);
            //    }
            //}
            //inv.aadetail = new List<ACC011AA>();
            //inv.aqdetail = new List<ACC011AQ>();
            //List<ACC011AA> detail = new List<ACC011AA>();
            //foreach (ACC011AA detail in inv.aadetail)
            //{
            //    detail.TRANS_TYPE = "ST_RS_RSO_O";
            //    detail.VOU_ID = inv.a9master.VOU_ID;
            //    row++;
            //    detail.COUNTER = row.ToString();
            //    //inv.aadetail.Add(detail);
            //}
            //ACC011AA detail = new ACC011AA();
            #endregion
            int row = 0;
            
            #region ACC011AA
            //string aq_doc_id = _ctx.APM.Where(w => w.DOC_ID.StartsWith("06")).Max(q => q.DOC_ID);
            //final
            foreach (ACC011AA i in inv.aadetail)
            {
                i.TRANS_TYPE = "ST_RS_RSO_O";
                i.VOU_ID = inv.a9master.VOU_ID;
                row++;
                i.COUNTER = row.ToString().PadLeft(4,'0');
                i.VOU_DATE = i.ADD_DATE = i.LAST_DATE = DateTime.Now.ToString("yyy-MM-dd");
                i.STORE_ID = "02";
                i.BATCH_ID = "";
                i.EXP_DATE = "";
                i.C_C_ID = "00/00";
                i.PACK_UNITS = 1;
                //qty, item_id, ratio, 
                i.TOTAL_COST = 0;
                i.ITEM_COST = 0;
                i.RATIO = 0;
                i.REL_ID = "";
                i.PERIOD_NO = inv.a9master.PERIOD_NO;
                i.DLV_QTY = 0;
                i.NEW_COST = 0;
                i.COMP_ID = "001";
                i.USER_ID = i.LAST_USER= inv.apmaster.USER_ID;
                i.S_AUTO_KEY = 0;
                i.ADD_TIME = DateTime.Now.ToString("HH:mm:ss");
                i.SENT = "0";
                i.S_SERIAL = "SA005672TP83L19";
                i.VOU_SIGN = 0;
                i.V_DISTR_ID = "0000";
                i.ST_LOC_ID = "";
                //i.VOU_SIGN = -1;
                i.QTY2 = 0;

                _ctx.AAD.Add(i);
                //_ctx.SaveChanges();
                //inv.asctail.Add(detail);
            }
            #endregion
            #region cleanup
            //inv.aqdetail = new List<ACC011AQ>();
            //for (int x = 0; x < inv.aadetail.Count; x++)
            //{

            //    //inv.aqdetail[x].DOC_ID = aq_doc_id;
            //    inv.aqdetail[x].DOC_ID = aq_doc_id;
            //    inv.aqdetail[x].COUNTER = (x + 1).ToString();
            //    inv.aqdetail[x].ITEM_ID = inv.aadetail[x].ITEM_ID;
            //    inv.aqdetail[x].ADD_DATE = DateTime.Now.ToString("yyy-MM-dd");
            //    _ctx.AQD.Add(inv.aqdetail[x]);
            //}
            #endregion

            #region ACC011AQ
            row = 0;
            foreach (ACC011AQ aq in inv.aqdetail)
            {
                aq.DOC_ID = inv.apmaster.DOC_ID;
                row++;
                aq.COUNTER = row.ToString().PadLeft(4, '0');
                //item_id
                aq.UNIT = "";
                //qty_req
                //unit_price
                aq.DISC_RATIO = 0;
                aq.DISC_VAL = 0;
                //net_price
                //tot_price
                aq.SENT = "0";
                aq.MODULE_ID = "SA";
                aq.PACK_UNITS = 0;
                aq.COMP_ID = "001";
                aq.ADD_DATE = aq.ADD_TIME = DateTime.Now.ToString("yyy-MM-dd");
                aq.USER_ID = aq.LAST_USER = inv.apmaster.LAST_USER;
                aq.ADD_TIME = DateTime.Now.ToString("HH:mm:ss");
                aq.S_SERIAL = inv.apmaster.DOC_ID+ aq.ITEM_ID + aq.COUNTER;
                //item_bp, item_bv, 
                _ctx.AQD.Add(aq);
            }
            #endregion
            _ctx.APM.Add(inv.apmaster);
            _ctx.A9M.Add(inv.a9master);
            _ctx.SaveChanges();
            //total price
            return Created(new Uri(Request.RequestUri + "/" + inv.apmaster.DISTR_ID), new { id = inv.apmaster.DOC_ID, amt = inv.apmaster.NET_TOTAL/*, policy =inv.apmaster.DS_SHIPMENT */});
        }
        //to be implimented
        //[Route("api/invoice/fees/{id}")]
        //[HttpPut]
        //public IHttpActionResult newMemberFees(string id)
        //{
        //    InvoiceDTO init = new InvoiceDTO();
        //    init.
        //    return Created();
        //}
    }
}