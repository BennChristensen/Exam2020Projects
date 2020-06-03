namespace Example08.Migrations
{
    using Example08.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Example08.Storage.BlogsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Example08.Storage.BlogsContext context)
        {
            var blog = new Blog { Name = "Alt om cykling" };
            blog.Posts.Add(new Post { Headline = "Hvordan man justere en bræmse.", 
                Content = "Start med at løsne ..."});
            context.Blogs.AddOrUpdate(b => b.Name, blog);
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
