using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWayAPI.Models
{
    public class MemberInvoiceDTO
    {
        public ACC011AP apmaster { set; get; }
        public ACC011AQ aqdetail { set; get; }
    }
}