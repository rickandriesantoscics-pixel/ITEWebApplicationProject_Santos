using SegundaMano.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SegundaMano.Models.Maps
{
    public class TblOrderStatusesMap : EntityTypeConfiguration<TblOrderStatusesModel>
    {
        public TblOrderStatusesMap()
        {
            HasKey(i => i.orderStatusID);
            ToTable("tblOrderStatuses");
        }
    }
}
