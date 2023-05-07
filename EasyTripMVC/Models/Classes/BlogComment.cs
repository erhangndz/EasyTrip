using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyTripMVC.Models.Classes
{
    public class BlogComment
    {
        public IEnumerable<Blog> blogs { get; set; }
        public IEnumerable<Comment> comments { get; set; }
        public IEnumerable<Blog> blogs2 { get; set; }
    }
}