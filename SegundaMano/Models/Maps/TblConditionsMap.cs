using SegundaMano.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SegundaMano.Models.Maps
{
    public class TblConditionsMap : EntityTypeConfiguration<TblConditionsModel>
    {
        public TblConditionsMap()
        {
            HasKey(i => i.conditionID);
            ToTable("tblConditions");
        }
    }
}
