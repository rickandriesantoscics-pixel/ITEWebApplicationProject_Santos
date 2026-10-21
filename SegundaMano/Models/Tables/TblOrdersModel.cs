using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegundaMano.Models.Tables
{
    public class TblOrdersModel
    {
        public int orderID { get; set; }
        public int userID { get; set; }
        public int fulfillmentMethodID { get; set; }
        public int orderStatusID { get; set; }
        public decimal birthdayDiscountAmount { get; set; }
        public decimal deliveryFee { get; set; }
        public DateTime canceledAt { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
