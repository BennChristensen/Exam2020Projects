using Example08.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Example08.Storage
{
    public class BlogsContext :DbContext
    {
        public BlogsContext() : base("name=BlogsConnectionString")
        {

        }
        public DbSet<Blog> Blogs { get; set; }
    }
}