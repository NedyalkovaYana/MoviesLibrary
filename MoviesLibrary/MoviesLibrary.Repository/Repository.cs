using System.Linq;

namespace MoviesLibrary.Repository
{

    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using MoviesLibrary.Data;
    using Microsoft.EntityFrameworkCore;

    public class Repository<T> : IRepository<T>
        where T : class
    {
        private readonly IMoviesLibraryDBContext _context;
        private readonly DbSet<T> Set;
        public Repository(IMoviesLibraryDBContext context)
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
    }
}
