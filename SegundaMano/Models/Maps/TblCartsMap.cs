using ITEWebApplicationProject.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ITEWebApplicationProject.Models.Maps
{
    public class TblCartsMap : EntityTypeConfiguration<TblCartsModel>
    {
        public TblCartsMap()
        {
            HasKey(i => i.cartID);
            ToTable("tblCarts");
        }
    }
}
