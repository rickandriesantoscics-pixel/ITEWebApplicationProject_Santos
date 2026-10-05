using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITEWebApplicationProject.Models
{
    public class CustomerModel
    {
        public string CustomerID { get; set; }
        public string Username { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string Suffix { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ContactNumber { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
    }
}
