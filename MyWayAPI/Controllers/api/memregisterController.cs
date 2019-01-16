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
    public class memregisterController : ApiController
    {
        private readonly DBC _ctx;
        public memregisterController()
        {
            _ctx = new DBC();
        }
        [Route("api/allmembers")]
        [HttpGet]
        public IHttpActionResult getallmembers()
        {

            return Ok(_ctx.Member.Select(w => new { w.DISTR_ID, w.ANAME, w.DISTR_IDENT, w.ADDRESS, w.TELEPHONE, w.E_MAIL }));
        }
        [Route("api/memberid/{id}")]
        [HttpGet]
        public IHttpActionResult getmembersbyid(string id)
        {
            List<getmemberID_Result> x = new List<getmemberID_Result>();
            var test = new Entities3();
            var reslist = test.getmemberID(id).ToList();
            foreach (var pen in reslist.ToList())
            {
                x.Add(
                    new getmemberID_Result
                    {
                        DISTR_ID = pen.DISTR_ID,
                        ANAME = pen.ANAME,
                        DISTR_IDENT = pen.DISTR_IDENT,
                        ADDRESS = pen.ADDRESS,
                        TELEPHONE = pen.TELEPHONE,
                        E_MAIL = pen.E_MAIL,
                        AREA_ID = pen.AREA_ID,
                        AREA_NAME = pen.AREA_NAME
                    }
                    );
            }
            return Ok(x);

        }
        [HttpPut]
        public IHttpActionResult newstuff(ACC011AZ1 newMember)
        {
            //ACC011AZ1 mem = new ACC011AZ1();
            //the "10" can be replaced by any starting value
            string maxIDplus = _ctx.Member.Where(w => w.DISTR_ID.StartsWith("06")).Max(q => q.DISTR_ID);
            string distr_sub = maxIDplus.Substring(2, maxIDplus.Length - 2);

            int zeroCount = 0;
            for (int i = 0; i < distr_sub.Length; i++)
            {
                if (distr_sub[i] == '0')
                    zeroCount++;
                else break;
            }

            int int_distr_sub = 0;

            if (int.TryParse(distr_sub, out int_distr_sub))
            {
                int_distr_sub++;
                maxIDplus = int_distr_sub.ToString();
                maxIDplus = maxIDplus.PadLeft(distr_sub.Length, '0');
                maxIDplus = maxIDplus.Insert(0, "06");
            }

            newMember.DISTR_ID = maxIDplus;
            newMember.DETAILED = "1";
            //sponsor_id gy mn el user
            //to calculate icode
            string sponsorID = newMember.SPONSOR_ID;
            var sponsorIcode = _ctx.Member.Where(x => x.DISTR_ID == sponsorID).Select(w => w.ICODE).SingleOrDefault();
            newMember.DISTR_ORDER = _ctx.Member.Where(w => w.ICODE.StartsWith(sponsorIcode) && w.ICODE.Length == sponsorIcode.Length + 5).Max(l => l.DISTR_ORDER);

            if (newMember.DISTR_ORDER == null)
                newMember.DISTR_ORDER = 1;
            else
                newMember.DISTR_ORDER++;

            newMember.ICODE = sponsorIcode;
            string temp = "";
            string distr_index = newMember.DISTR_ID.Substring(0, 2);

            int int_index = int.Parse(distr_index);
            temp = Base36.Encode(int_index);
            temp = temp.PadLeft(2, '0');
            newMember.ICODE = newMember.ICODE + temp;
            temp = Base36.Encode(newMember.DISTR_ORDER);
            temp = temp.PadLeft(3, '0');

            newMember.ICODE = newMember.ICODE + temp;
            newMember.DISTR_LEVEL = newMember.ICODE.Length / 5;

            newMember.DETAILED = "1";
            newMember.SHIFT_ID = "012";
            //02
            newMember.SERVICE_CENTER = "06";
            newMember.JOIN_DATE = DateTime.Now.ToString("yyy-MM-dd");
            newMember.CURRENT_DISTR_TYPE_ID = "00";
            newMember.DIRECTOR_ID = "00000000";
            newMember.YEAR_DISTR_TYPE = "";
            newMember.IDENT_LPLACE = "";
            newMember.DUE_DAYS = 0;
            newMember.SM_ID = "00";
            newMember.GROUP_ID = "00/000";
            newMember.CRE_LIMIT = 0;
            newMember.MODULE_ID = "SA";
            newMember.COMP_ID = "001";
            newMember.SENT = "0";
            newMember.CR_LMT_TYP = null;
            newMember.AR_AC_ID = "00000000";
            newMember.ADD_DATE = newMember.LAST_DATE = newMember.JOIN_DATE;
            newMember.LAST_USER = newMember.USER_ID = "006";
            newMember.S_AUTO_KEY = 0;
            newMember.ADD_TIME = DateTime.Now.ToString("HH:mm:ss");
            //s_serial empty string
            newMember.S_SERIAL = "TEST";
            newMember.REG_FEES = 30;
            newMember.PAID_FEES = 0;
            newMember.FEES_TYPE = "1";
            newMember.YEAR_STATUS = "999999999999";
            newMember.LAST_RENEWAL_DATE = DateTime.Now.ToString("yyy-MM-dd");

            var dupe = _ctx.Member.Select(w => w.DISTR_IDENT).ToList();

            if (dupe.Contains(newMember.DISTR_IDENT))
                return Content(HttpStatusCode.Conflict, "User Identity Already Exists. Please try again.");

            _ctx.Member.Add(newMember);
            _ctx.SaveChanges();

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

            MemberInvoiceDTO memberInvoiceDTO = new MemberInvoiceDTO
            {
                apmaster = new ACC011AP
                {
                    DOC_ID = vouIDplus,
                    DISTR_ID = newMember.DISTR_ID,
                    S_SERIAL = newMember.DISTR_ID + vouIDplus,
                    NET_TOTAL = 30,
                    QUOT_ID = "",
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
                    DS_SHIPMENT = "023000000000"

                },
                aqdetail = new ACC011AQ
                {
                    DOC_ID = vouIDplus,
                    
                    COUNTER = "0001",
                    ITEM_ID = "99M",
                    UNIT = "",
                    QTY_REQ = 1,
                    UNIT_PRICE = 30,
                    TOT_PRICE = 30,
                    ITEM_BP = 0,
                    ITEM_BV = 0,
                    //unit_price
                    DISC_RATIO = 0,
                    DISC_VAL = 0,
                    NET_PRICE = 30,
                   
                    //net_price
                    //tot_price
                    SENT = "0",
                    MODULE_ID = "SA",
                    PACK_UNITS = 0,
                    COMP_ID = "001",
                    ADD_DATE = DateTime.Now.ToString("yyy-MM-dd"),
                    LAST_DATE = DateTime.Now.ToString("yyy-MM-dd"),
                    USER_ID = "006",
                    LAST_USER = "006",
                    ADD_TIME = DateTime.Now.ToString("HH:mm:ss"),
                    S_SERIAL = vouIDplus + "99M" + "0001",
                }
                
            };
            _ctx.APM.Add(memberInvoiceDTO.apmaster);
            _ctx.SaveChanges();
            _ctx.AQD.Add(memberInvoiceDTO.aqdetail);
            _ctx.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + newMember.DISTR_ID), new { id = newMember.DISTR_ID });

        }

        [HttpPost]
        public IHttpActionResult UpdateMem(string distrid, ACC011AZ1 existingmem)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var exist = _ctx.Member.SingleOrDefault(e => e.DISTR_ID == distrid);
            if (exist == null)
                return NotFound();

            exist.ANAME = existingmem.ANAME;
            exist.ADDRESS = existingmem.ADDRESS;
            exist.E_MAIL = existingmem.E_MAIL;
            exist.TELEPHONE = existingmem.TELEPHONE;

            return Ok();
        }

    }
}