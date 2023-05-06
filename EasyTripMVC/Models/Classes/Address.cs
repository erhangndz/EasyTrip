using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyTripMVC.Models.Classes
{
    public class Address
    {
        public int AddressID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address1 { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
    }
}