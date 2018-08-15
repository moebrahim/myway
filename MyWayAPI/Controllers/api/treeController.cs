using MyWayAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MyWayAPI.Controllers.api
{
    public class treeController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Gettree(string id)
        {
            List<apiReport_Result> reportList = new List<apiReport_Result>();
            var test = new Entities();
            var result = test.apiReport(id).ToList();
            foreach (var item in result.ToList())
            {
                reportList.Add(new apiReport_Result
                {
                    DISTR_ID = item.DISTR_ID,
                    name = item.name,
                    per_bp = item.per_bp,
                    SUM = item.SUM,
                    RATIO = item.RATIO,
                    area = item.area,
                    sponser_id = item.sponser_id,
                    sponser_name = item.sponser_name
                });
            }
            return Ok(reportList);
        }
    }
}
