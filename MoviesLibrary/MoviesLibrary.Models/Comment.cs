using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesLibrary.Models
{
    using System;

    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }

        [ForeignKey("Autor")]
        public int AutorId { get; set; }
        public User Autor { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
