﻿using MyWayAPI.Models;
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
            var x = new DistrRepSum();
            var res = x.distrRepSummary(distrID);
            return Ok(res);
        }
        
    }
}