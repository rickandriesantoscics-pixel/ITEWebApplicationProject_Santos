using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegundaMano.Models.Tables
{
    public class TblProductMeasurementsModel
    {
        public int productMeasurementID { get; set; }
        public int productID { get; set; }
        public int measurementTypeID { get; set; }
        public decimal measurementValue { get; set; }
        public string measurementUnit { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
