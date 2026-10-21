using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegundaMano.Models.Tables
{
    public class TblProductImagesModel
    {
        public int imageID { get; set; }
        public int productID { get; set; }
        public string imagePath { get; set; }
        public bool isPrimary { get; set; }
        public int displayOrder { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
