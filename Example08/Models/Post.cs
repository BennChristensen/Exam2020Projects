using System.Collections.Generic;

namespace Example08.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Headline { get; set; }
        public string Content { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public int Likes { get; set; }
    }
}