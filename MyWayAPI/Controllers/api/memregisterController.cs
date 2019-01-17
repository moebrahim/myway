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
            #region member
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
            #endregion
            string vouIDplusApAq = _ctx.APM.Where(w => w.DOC_ID.StartsWith("06")).Max(q => q.DOC_ID);
            string vouSub = vouIDplusApAq.Substring(2, vouIDplusApAq.Length - 2);
            int vouSubInt = 0;
            if (int.TryParse(vouSub, out vouSubInt))
            {
                vouSubInt++;
                vouIDplusApAq = vouSubInt.ToString();
                vouIDplusApAq = vouIDplusApAq.PadLeft(vouSub.Length, '0');
                vouIDplusApAq = vouIDplusApAq.Insert(0, "06");
            }

            string vouIDplus = _ctx.A9M.Where(w => w.VOU_ID.StartsWith("06")).Where(x => x.TRANS_TYPE == "ST_RS_RSO_O").Max(q => q.VOU_ID);
            string vouSub1 = vouIDplus.Substring(2, vouIDplus.Length - 2);
            int vouSubInt1 = 0;
            if (int.TryParse(vouSub1, out vouSubInt1))
            {
                vouSubInt1++;
                vouIDplus = vouSubInt1.ToString();
                vouIDplus = vouIDplus.PadLeft(vouSub1.Length, '0');
                vouIDplus = vouIDplus.Insert(0, "06");
            }
            var pn = Convert.ToDouble(_ctx.Periods.Where(w => w.MODULE_ID == "SA").Select(x => x.LAST_OPEN).SingleOrDefault());
            MemberInvoiceDTO memberInvoiceDTO = new MemberInvoiceDTO
            {
                apmaster = new ACC011AP
                {

                    DOC_ID = vouIDplusApAq,
                    DISTR_ID = newMember.DISTR_ID,
                    S_SERIAL = newMember.DISTR_ID + vouIDplusApAq,
                    NET_TOTAL = 30,
                    QUOT_ID = vouIDplus,
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
                    DS_SHIPMENT = "023000000000",
                    AREMARKS = "عضوية جديدة"

                },
                aqdetail = new ACC011AQ
                {
                    DOC_ID = vouIDplusApAq,

                    COUNTER = "0001",
                    ITEM_ID = "99m",
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
                    S_SERIAL = vouIDplusApAq + "99m" + "0001",
                },
                a9master = new ACC011A9
                {

                    VOU_ID = vouIDplus,
                    TRANS_TYPE = "ST_RS_RSO_O",
                    VOU_DATE = DateTime.Now.ToString("yyy-MM-dd"),
                    ADD_DATE = DateTime.Now.ToString("yyy-MM-dd"),
                    LAST_DATE = DateTime.Now.ToString("yyy-MM-dd"),
                    CUS_VEN_ID = newMember.DISTR_ID,

                    //adescr is ""
                    ADESCR = "",
                    LDESCR = "",
                    PRJ_ID = "00",
                    //make sure it's 06
                    STORE_ID = "02",
                    TO_ST_ID = "",
                    // CUS_VEN_ID distr_id .. input
                    BRANCH_ID = "02",
                    DOC_ID = "",
                    USE_RSRV = "0",
                    PERIOD_NO = pn,
                    TOTAL_COST = 30,
                    POSTED = "0",
                    NO_MODIFY = "0",

                    SENT = "0",
                    MODULE_ID = "SA",
                    // USER_ID =  LAST_USER = "006",
                    COMP_ID = "001",
                    S_AUTO_KEY = 1,
                    V_DISTR_ID = "0000",
                    ADD_TIME = DateTime.UtcNow.ToString("HH:mm:ss"),//AddHours(1).ToString("HH:mm:ss"),//+ DateTime.Parse("01:00:00"),//DateTime.Now.ToString("HH:mm:ss"),
                    S_SERIAL = "SA0053A2LIZQH00",
                    REC_OWNER = "U",
                    DS_SHIPMENT = "023000000000"
                    //AREMARKS = "عضوية جديدة"

                },
                aadetail = new ACC011AA
                {
                    // DOC_ID = vouIDplus,

                    TRANS_TYPE = "ST_RS_RSO_O",
                    VOU_ID = vouIDplus,
                    ITEM_ID = "99m",
                    COUNTER = "0001",
                    VOU_DATE = DateTime.Now.ToString("yyy-MM-dd"),
                    ADD_DATE = DateTime.Now.ToString("yyy-MM-dd"),
                    LAST_DATE = DateTime.Now.ToString("yyy-MM-dd"),
                    STORE_ID = "02",
                    BATCH_ID = "",
                    EXP_DATE = "",
                    C_C_ID = "00/00",
                    PACK_UNITS = 1,
                    //qty, item_id, ratio, 
                    TOTAL_COST = 0,
                    ITEM_COST = 0,
                    RATIO = 0,
                    REL_ID = "",
                    PERIOD_NO = pn,
                    DLV_QTY = 0,
                    NEW_COST = 0,
                    COMP_ID = "001",
                    USER_ID = "006",
                    LAST_USER = "006",
                    QTY = 1,
                    S_AUTO_KEY = 0,
                    ADD_TIME = DateTime.Now.ToString("HH:mm:ss"),
                    SENT = "0",
                    S_SERIAL = "SA005672TP83L19",
                    VOU_SIGN = 0,
                    V_DISTR_ID = "0000",
                    ST_LOC_ID = "",
                    // VOU_SIGN = -1,
                    QTY2 = 0,
                }

            };
            _ctx.APM.Add(memberInvoiceDTO.apmaster);
            //_ctx.SaveChanges();
            _ctx.AQD.Add(memberInvoiceDTO.aqdetail);
            //_ctx.SaveChanges();

            _ctx.AAD.Add(memberInvoiceDTO.aadetail);
            //_ctx.SaveChanges();
            _ctx.A9M.Add(memberInvoiceDTO.a9master);
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