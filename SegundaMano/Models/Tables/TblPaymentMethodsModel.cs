using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITEWebApplicationProject.Models.Tables
{
    public class TblPaymentMethodsModel
    {
        public int paymentMethodID { get; set; }
        public string paymentMethodName { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
