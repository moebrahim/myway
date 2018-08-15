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
            return Ok(_ctx.Member.Select(w => new { w.DISTR_ID, w.ANAME, w.DISTR_IDENT, w.ADDRESS, w.TELEPHONE, w.E_MAIL }).Where(s=>s.DISTR_ID==id));

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
            newMember.SERVICE_CENTER = "02";
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
            newMember.REG_FEES = 10;
            newMember.PAID_FEES = 0;
            newMember.FEES_TYPE = "1";
            newMember.YEAR_STATUS = "999999999999";
            newMember.LAST_RENEWAL_DATE = DateTime.Now.ToString("yyy-MM-dd");

            var dupe = _ctx.Member.Select(w => w.DISTR_IDENT).ToList();

            if (dupe.Exists(i => i.Equals(newMember.DISTR_IDENT)))
                return Content(HttpStatusCode.Conflict, "User Identity Already Exists.");

            _ctx.Member.Add(newMember);
            _ctx.SaveChanges();



            return Created(new Uri(Request.RequestUri + "/" + newMember.DISTR_ID), newMember);
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