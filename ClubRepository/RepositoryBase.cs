using ClubContracts;
using ClubModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClubRepository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext _repositoryContext;

        public RepositoryBase(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IQueryable<T> FindAll(bool trackChanges) =>
            trackChanges ?
                _repositoryContext.Set<T>() :
                _repositoryContext.Set<T>().AsNoTracking();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            trackChanges ?
                _repositoryContext.Set<T>().Where(expression) :
                _repositoryContext.Set<T>().Where(expression).AsNoTracking();

        public void Create(T entity) =>
            _repositoryContext.Add(entity);

        public void Update(T entity) =>
            _repositoryContext.Update(entity);

        public void Delete(T entity) =>
            _repositoryContext.Remove(entity);
    }
}
