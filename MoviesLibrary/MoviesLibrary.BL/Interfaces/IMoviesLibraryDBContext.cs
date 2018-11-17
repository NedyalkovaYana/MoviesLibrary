namespace MoviesLibrary.BL.Interfaces
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;

    public interface IMoviesLibraryDBContext : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync();
    }
}
