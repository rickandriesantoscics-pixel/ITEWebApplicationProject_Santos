using ITEWebApplicationProject.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ITEWebApplicationProject.Models.Maps
{
    public class TblPaymentStatusesMap : EntityTypeConfiguration<TblPaymentStatusesModel>
    {
        public TblPaymentStatusesMap()
        {
            HasKey(i => i.paymentStatusID);
            ToTable("tblPaymentStatuses");
        }
    }
}
