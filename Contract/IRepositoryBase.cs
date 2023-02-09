using IndigoLabs2.Models;
using System.Linq.Expressions;

namespace IndigoLabs2.Contract
{
    public interface IRepositoryBase<T>
    {
        //Task<User> GetUser(int id);
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
