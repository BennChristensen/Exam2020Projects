using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example08.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Post> Posts { get; set; } = new List<Post>();
    }
}