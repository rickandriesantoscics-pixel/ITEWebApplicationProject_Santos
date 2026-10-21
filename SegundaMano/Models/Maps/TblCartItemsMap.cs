using SegundaMano.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SegundaMano.Models.Maps
{
    public class TblCartItemsMap : EntityTypeConfiguration<TblCartItemsModel>
    {
        public TblCartItemsMap()
        {
            HasKey(i => i.cartItemID);
            ToTable("tblCartItems");
        }
    }
}
