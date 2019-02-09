using MyWayAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace MyWayAPI.Controllers.api
{
    public class leaderverificationController : ApiController
    {
         private readonly DBC _ctx;
         public leaderverificationController()
        {
            _ctx = new DBC();
        }

        [Route("api/leaderverification/{leaderID}/{distrID}")]
        [HttpGet]
        public IHttpActionResult verifyLeader (string leaderID, string distrID)
         {
             var test = new verification();

            var x = test.LEADER_verification(leaderID, distrID);

            return Ok(x);
         }

        [Route("api/distrrepsummary/{distrID}")]
        [HttpGet]
        public IHttpActionResult distrRep(string distrID)
        {
            List<distrRepSummary_Result> invres = new List<distrRepSummary_Result>();
            var con = new API_REPORTDBEntities2();
            var res = con.distrRepSummary(distrID);
            foreach (var inv in res.ToList())
            {
                invres.Add(new distrRepSummary_Result
                {
                    distr_id = inv.distr_id,
                    M_ANAME = inv.M_ANAME,
                    per_bp = inv.per_bp,
                    PGROUP_BP = inv.PGROUP_BP,
                    TOTAL_BP = inv.TOTAL_BP,
                    m_ratio = inv.m_ratio,
                    LEADER_ID_N = inv.LEADER_ID_N,
                    L_ANAME = inv.L_ANAME,
                    SPONSOR_ID = inv.SPONSOR_ID,
                    S_ANAME = inv.S_ANAME,
                    COUNT = inv.COUNT,
                    AREA = inv.AREA,
                    LASTUPDATE = inv.LASTUPDATE,
                    NEXTUPDATE = inv.NEXTUPDATE
                });

            }
            return Ok(invres);
        }
        
    }
}