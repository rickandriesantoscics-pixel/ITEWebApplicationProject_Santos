using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITEWebApplicationProject.Models.Tables
{
    public class TblOrderItemsModel
    {
        public int orderItemID { get; set; }
        public int orderID { get; set; }
        public int productID { get; set; }
        public int quantity { get; set; }
        public decimal unitPrice { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
