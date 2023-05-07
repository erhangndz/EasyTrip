using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyTripMVC.Models.Classes
{
    public class HomePage
    {
        public int HomePageID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }

    }
}