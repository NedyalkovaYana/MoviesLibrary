namespace MoviesLibrary.Data
{
    using MoviesLibrary.Models;
    using Microsoft.EntityFrameworkCore;

    public interface IMoviesLibraryDbContext
    {
        DbSet<T> Set<T>() where T : class;
        DbSet<Actor> Actors { get; set; }
        //DbSet<Category> Categories { get; set; }
        DbSet<Comment> Comments { get; set; }
        DbSet<Movie> Movies { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<UserAccount> UserAccounts { get; set; }
    }
}
