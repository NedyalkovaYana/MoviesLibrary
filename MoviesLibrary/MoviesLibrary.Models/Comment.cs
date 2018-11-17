namespace MoviesLibrary.Models
{
    using System;

    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public User Autor { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
