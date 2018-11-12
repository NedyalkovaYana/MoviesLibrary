namespace MoviesLibrary.Models
{
    using System;

    public class Comment
    {
        public int Id { get; set; }
        public string Author { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
