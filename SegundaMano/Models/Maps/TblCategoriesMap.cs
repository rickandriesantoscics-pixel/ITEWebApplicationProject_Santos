using SegundaMano.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SegundaMano.Models.Maps
{
    public class TblCategoriesMap : EntityTypeConfiguration<TblCategoriesModel>
    {
        public TblCategoriesMap()
        {
            HasKey(i => i.categoryID);
            ToTable("tblCategories");
        }
    }
}
