﻿using MyWayAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MyWayAPI.Controllers.api
{
    public class pendingController : ApiController
    {
        [Route("api/pending/{id}")]
        [HttpGet]
        public IHttpActionResult getpendingsalesorder (string id)
        {
            List<PENDING_Result> pendinglist = new List<PENDING_Result>();
            var test = new Entities1();
            var reslist = test.PENDING(id).ToList();
            foreach(var pen in reslist.ToList())
            {
                pendinglist.Add(
                    new PENDING_Result
                    {
                        DOC_ID = pen.DOC_ID,
                        ITEM_ID = pen.ITEM_ID,
                        ANAME = pen.ANAME,
                        COUNTER = pen.COUNTER,
                        QTY_REQ = pen.QTY_REQ,
                        UNIT_PRICE = pen.UNIT_PRICE,
                        TOT_PRICE = pen.TOT_PRICE,
                        ITEM_BP = pen.ITEM_BP,
                        TOTAL_BP = pen.TOTAL_BP,
                        DOC_DATE = pen.DOC_DATE
                    }
                    );
            }
            return Ok(pendinglist);
        }
    }
}