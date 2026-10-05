using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITEWebApplicationProject.Models.Tables
{
    public class TblPaymentsModel
    {
        public int paymentID { get; set; }
        public int orderID { get; set; }
        public int paymentMethodID { get; set; }
        public int paymentStatusID { get; set; }
        public int? statusUpdatedByUserID { get; set; }
        public DateTime paidAt { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
