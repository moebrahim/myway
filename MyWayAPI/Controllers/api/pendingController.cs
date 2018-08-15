using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using MyWayAPI.Models;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;

namespace MyWayAPI.Controllers.api
{
    public class pendingController : ApiController
    {
        private readonly DBC _ctx;
        public pendingController()
        {
            _ctx = new DBC();
        }
        [Route("api/pending/{distrID}")]
        [HttpGet]
        public IHttpActionResult getpending (string distrID)
        {
            int period = 31;//(int)_ctx.Periods.Where(q => q.MODULE_ID == "SA").Select(w => w.LAST_OPEN).SingleOrDefault();
            //Pending pending = new Pending();
            //pending.A9Vou_ID = _ctx.A9M.Where(q=>q.TRANS_TYPE == "ST_RS_RSO_O" && q.CUS_VEN_ID == distrID && q.PERIOD_NO == period).Select(w=>w.VOU_ID).ToList();
            List<string> VouIdsCurrentPeriod = _ctx.A9M.Where(q => q.TRANS_TYPE == "ST_RS_RSO_O" && q.CUS_VEN_ID == distrID && q.PERIOD_NO == period).Select(w => w.VOU_ID).ToList();
            int loopsize = VouIdsCurrentPeriod.Count;
            string filter;
            List<IQueryable> qq= new List<IQueryable>();
            string doc_id;// = "02055207";
            List<Pending> p = new List<Pending>();
            List<IQueryable> qe = new List<IQueryable>();
            for (int i = loopsize - 1; i >= 0; i--)
            {
                filter = VouIdsCurrentPeriod[i];
                filter = _ctx.APM.Where(w => w.QUOT_ID == filter).Select(e => e.DOC_ID).SingleOrDefault();
                if (filter == null)
                {
                    VouIdsCurrentPeriod.RemoveAt(i);
                }
                else
                {

                    //doc_id = _ctx.APM.Where(w => w.QUOT_ID == filter).Select(e => e.DOC_ID).SingleOrDefault();//VouIdsCurrentPeriod[i];
                    qq.Add (from b in _ctx.AQD
                           where b.DOC_ID == filter
                           join a in _ctx.Products on b.ITEM_ID equals a.ITEM_ID
                           join c in _ctx.APM on b.DOC_ID equals c.DOC_ID

                           select new Pending
                           {
                               docid = filter,
                               ItemId = b.ITEM_ID,
                               ItemName = a.ANAME,
                               ItemSubTotalPoints = b.ITEM_BP,
                               Quantity = b.QTY_REQ,
                               SubTotalPrice = b.TOT_PRICE
                           });

                    

                }

            }
            //List<string> x = new List<string>(pending.A9Vou_ID.Count);
            //database Quot_ID != code A9Vou_ID ? > remove current item
            //string filter;
            //pending.APQDoc_ID = new List<string>(pending.A9Vou_ID.Count);
            //int loopsize = pending.A9Vou_ID.Count;
            //string h;
            //for (int i = pending.A9Vou_ID.Count -1 ; i >= 0; i--)
            //for (int i = loopsize-1; i >= 0; i-- )
            //{

            //    filter = pending.A9Vou_ID[i];
            //    filter = _ctx.APM.Where(w => w.QUOT_ID == filter).Select(e => e.DOC_ID).SingleOrDefault();
            //    if (filter == null)
            //    {
            //        pending.A9Vou_ID.RemoveAt(i);

            //    }
            //    else
            //    {

            //        pending.APQDoc_ID.Add(filter);
            //        //pending.AQ = _ctx.AQD.Where(w => w.DOC_ID == pending.APQDoc_ID[i]).Select(q=>q.ITEM_ID).ToString();
            //    }
            //}
            //Pending pending = new Pending();
            //pending.APQDoc_ID = _ctx.AQD.Where(q => q.DOC_ID == "02055207").Select(w => new { w.ITEM_ID, w.QTY_REQ, w.ITEM_BP, w.TOT_PRICE});
            //pending.date = _ctx.APM.Where(q => q.DOC_ID == "02055207").Select(w => new { w.ADD_DATE, w.NET_TOTAL });
            
            
            /*select b.DOC_ID,b.ITEM_ID, a.ANAME, b.QTY_REQ, b.ITEM_BP, b.TOT_PRICE, C.ADD_DATE
              from acc011a3 a, ACC011AQ b, ACC011AP c
              where b.DOC_ID = '02055207' and c.doc_id = b.doc_id and b.ITEM_ID = a.ITEM_ID*/
            //for (int i = 0; i < pending.A9Vou_ID.Count; i++)
            //{
            //    pending.APDoc_ID[i] = _ctx.APM.Where(w => w.QUOT_ID == pending.A9Vou_ID[i]).Select(q => q.DOC_ID).Single();
            //}

            return Ok(qq);
        }
    }
}