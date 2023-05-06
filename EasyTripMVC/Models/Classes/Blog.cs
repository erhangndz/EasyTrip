using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyTripMVC.Models.Classes
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description  { get; set; }
        public string BlogImage  { get; set; }
        public ICollection<Comment> Comments { get; set;}

    }
}