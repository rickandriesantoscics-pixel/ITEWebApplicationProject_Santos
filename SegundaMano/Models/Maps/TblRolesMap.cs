using ITEWebApplicationProject.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ITEWebApplicationProject.Models.Maps
{
    public class TblRolesMap : EntityTypeConfiguration<TblRolesModel>
    {
        public TblRolesMap()
        {
            HasKey(i => i.roleID);
            ToTable("tblRoles");
        }
    }
}
