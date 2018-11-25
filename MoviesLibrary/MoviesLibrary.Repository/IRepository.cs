namespace MoviesLibrary.Repository
{
    using System;
    using System.Linq.Expressions;
    using System.Collections.Generic;

    public interface IRepository<T>
        where T : class
    {
        IEnumerable<T> GetAll();
        T Find(object id);
        IEnumerable<T> Find(Expression<Func<T, bool>> filter);
        T GetById(object id);
        bool HasAny(Expression<Func<T, bool>> conditions);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(object id);
        void Save();
    }
}
