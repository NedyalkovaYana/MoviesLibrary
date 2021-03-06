﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesLibrary.Models
{
    using System.Collections.Generic;
    using MoviesLibrary.Common.Enums;

    public class User
    {
        public User()
        {
            this.FavoriteMovies = new List<Movie>();
            this.Comments = new List<Comment>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public byte[] Avatar {get; set;}

        public UserRole Role { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }

        public IEnumerable<Movie> FavoriteMovies { get; set; }

        [ForeignKey("Comment")]
        public int CommentId { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}
