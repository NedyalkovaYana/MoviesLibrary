﻿namespace MoviesLibrary.Data
{
    using MoviesLibrary.Models;
    using Microsoft.EntityFrameworkCore;
    using MoviesLibrary.Common.Enums;

    public class MoviesLibraryDBContext : DbContext
    {
        public MoviesLibraryDBContext(DbContextOptions options)
            : base(options)
        {
        }
        public MoviesLibraryDBContext()
        {
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>()
            .HasMany(m => m.Movies);

            modelBuilder.Entity<Movie>()
            .HasMany(c => c.Comments);

            modelBuilder.Entity<User>()
            .HasMany(c => c.Comments);

            modelBuilder.Entity<User>()
            .HasMany(m => m.FavoriteMovies);

            base.OnModelCreating(modelBuilder);
        }
    }
}