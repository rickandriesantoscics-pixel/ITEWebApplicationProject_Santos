using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegundaMano.Models.Tables
{
    public class TblPaymentStatusesModel
    {
        public int paymentStatusID { get; set; }
        public string paymentStatusName { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
