﻿namespace CodeFirstNewDatabaseSample
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        //TODO: Figure out how to add tags to each post

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
