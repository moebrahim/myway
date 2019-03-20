using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using MyWayAPI.Models;

namespace MyWayAPI.Controllers.api
{
    public class reportdbController : ApiController
    {
        [Route("api/newmembers/{distrID}")]
        [HttpGet]
        public IHttpActionResult newmembers(string distrID)
        {
            List<NEW_MEMBERS_Result> result = new List<NEW_MEMBERS_Result>();
            var ctx = new API_REPORTDBEntities3();
            var reslist = ctx.NEW_MEMBERS(distrID).ToList();

            foreach (var pen in reslist.ToList())
            {
                result.Add(
                    new NEW_MEMBERS_Result
                    {
                        distr_id = pen.distr_id,
                        distr_name = pen.distr_name,
                        area_name = pen.area_name,
                        TELEPHONE = pen.TELEPHONE,
                        per_bp = pen.per_bp,
                        JOIN_DATE = pen.JOIN_DATE
                    });
            }

            return Ok(result);

        }
        [Route("api/distrratio/{distrID}")]
        [HttpGet]
        public IHttpActionResult distrratio(string distrID)
        {
            var ctx = new API_REPORTDBEntities3();
            List<DISTR_RATIO_Result> result = new List<DISTR_RATIO_Result>();
            var reslist = ctx.DISTR_RATIO(distrID).ToList();
            foreach (var pen in reslist.ToList())
            {
                result.Add(
                    new DISTR_RATIO_Result
                    {
                        distr_id = pen.distr_id,
                        distr_name = pen.distr_name,
                        area_name = pen.area_name,
                        TELEPHONE = pen.TELEPHONE,
                        PGROUP_BP = pen.PGROUP_BP,
                        per_bp = pen.per_bp,
                        TOTAL_BP = pen.TOTAL_BP,
                        M_RATIO = pen.M_RATIO,
                        COUNT21 = pen.COUNT21

                    });
            }
            return Ok(result);
        }
    }
}