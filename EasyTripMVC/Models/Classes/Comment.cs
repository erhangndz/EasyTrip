using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyTripMVC.Models.Classes
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Comments { get; set; }
        public int BlogID { get; set; }
       public virtual Blog Blog { get; set; }
    }
}