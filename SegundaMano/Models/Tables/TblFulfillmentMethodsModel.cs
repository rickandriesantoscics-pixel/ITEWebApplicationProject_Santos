using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITEWebApplicationProject.Models.Tables
{
    public class TblFulfillmentMethodsModel
    {
        public int fulfillmentMethodID { get; set; }
        public string fulfillmentMethodName { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
