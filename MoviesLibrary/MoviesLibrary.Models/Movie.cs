﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using MoviesLibrary.Common.Enums;

    public class Movie
    {
        public Movie()
        {
            this.Stars = new HashSet<Actor>();
            this.Comments = new List<Comment>();
            this.Genres = new HashSet<MovieGenres>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Storyline { get; set; }

        public byte[] Poster { get; set; }

        public DateTime Duration { get; set; }

        public decimal AverageGrade { get; set; }

        public string DirectorName { get; set; }

        public string Writer { get; set; }

        [NotMapped]
        public IEnumerable<MovieGenres> Genres { get; set; }

        public int StarId { get; set; }

        [NotMapped]
        public IEnumerable<Actor> Stars { get; set; }

        [ForeignKey("Comment")]
        public int CommentId { get; set; }

        public IEnumerable<Comment> Comments { get; set; }

        public byte[] Trailer { get; set; }

        //Details??
    }
}
