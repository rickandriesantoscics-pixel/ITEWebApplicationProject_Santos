using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegundaMano.Models.Tables
{
    public class TblCartItemsModel
    {
        public int cartItemID { get; set; }
        public int cartID { get; set; }
        public int productID { get; set; }
        public int quantity { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
