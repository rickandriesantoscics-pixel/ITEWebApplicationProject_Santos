using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITEWebApplicationProject.Models.Tables
{
    public class TblCartsModel
    {
        public int cartID { get; set; }
        public int userID { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
