using SegundaMano.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SegundaMano.Models.Maps
{
    public class TblAddressesMap : EntityTypeConfiguration<TblAddressesModel>
    {
        public TblAddressesMap()
        {
            HasKey(i => i.addressID);
            ToTable("tblAddresses");
        }
    }
}