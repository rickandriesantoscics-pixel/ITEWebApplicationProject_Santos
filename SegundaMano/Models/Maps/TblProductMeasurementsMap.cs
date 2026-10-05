using ITEWebApplicationProject.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ITEWebApplicationProject.Models.Maps
{
    public class TblProductMeasurementsMap : EntityTypeConfiguration<TblProductMeasurementsModel>
    {
        public TblProductMeasurementsMap()
        {
            HasKey(i => i.productMeasurementID);
            ToTable("tblProductMeasurements");
        }
    }
}
