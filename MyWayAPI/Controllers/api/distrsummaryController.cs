using MyWayAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MyWayAPI.Controllers.api
{
    public class distrsummaryController: ApiController
    {
        [Route("api/distrsummary/{id}")]
        [HttpGet]
        public IHttpActionResult getsummary(string id)
        {
            List<distr_summary_Result> x = new List<distr_summary_Result>();
            var test = new Entities5();
            var reslist = test.distr_summary(id).ToList();
            foreach (var pen in reslist.ToList())
            {
                x.Add(
                    new distr_summary_Result
                    {
                        DISTR_ID = pen.DISTR_ID,
                        NAME = pen.NAME,
                        sponser_id = pen.sponser_id,
                        sponser_name = pen.sponser_name,
                        area = pen.area,
                        count = pen.count,
                        PER_BP = pen.PER_BP,
                        RATIO = pen.RATIO,
                        //Group_bp = pen.Group_bp,
                        SUM = pen.SUM                  
                    });
            }
            return Ok(x);
        }
    }
}