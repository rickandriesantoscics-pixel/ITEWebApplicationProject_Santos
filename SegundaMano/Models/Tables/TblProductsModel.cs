using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITEWebApplicationProject.Models.Tables
{
    public class TblProductsModel
    {
        public int productID { get; set; }
        public int categoryID { get; set; }
        public int conditionID { get; set; }
        public string productName { get; set; }
        public string brandName { get; set; }
        public string sizeLabel { get; set; }
        public string colorName { get; set; }
        public decimal price { get; set; }
        public int stockQuantity { get; set; }
        public string productDescription { get; set; }
        public bool isActive { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
