

namespace MoviesLibrary.Repository
{

    using System;
    using System.Linq;
    using MoviesLibrary.Data;
    using System.Linq.Expressions;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;

    public class Repository<T> : IRepository<T>
        where T : class
    {
        private readonly IMoviesLibraryDbContext _context;
        private readonly DbSet<T> Set;
        public Repository(IMoviesLibraryDbContext context)
        {
            this._context = context;
            this.Set = context.Set<T>();
        }


        public IEnumerable<T> GetAll()
        {
            return this._context.Set<T>().ToList();
        }

        public T Find(object id)
        {
            return this.Set.Find(id);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> filter)
        {
            return this._context.Set<T>.Where(filter);
        }

        public T GetById(object id)
        {
            return this._context.Set<T>().Find(id);
        }

        public bool HasAny(Expression<Func<T, bool>> conditions)
        {
            return this.Set.Any(conditions);
        }

        public void Add(T entity)
        {
            this._context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this._context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this._context.Set<T>().Delete(entity);
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            this._context.SaveChanges();
        }
    }
}
