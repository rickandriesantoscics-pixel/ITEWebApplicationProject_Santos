using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegundaMano.Models.Tables
{
    public class TblOrderAddressesModel
    {
        public int orderAddressID { get; set; }
        public int orderID { get; set; }
        public string recipientName { get; set; }
        public string phoneNumber { get; set; }
        public string houseUnit { get; set; }
        public string street { get; set; }
        public string barangay { get; set; }
        public string cityMunicipality { get; set; }
        public string province { get; set; }
        public string postalCode { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
