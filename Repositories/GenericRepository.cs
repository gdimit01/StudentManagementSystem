using System.Collections.Generic;
using System.Linq;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models.Interfaces;

namespace StudentManagementSystem.Repositories
{
    public class Genericrepository<T> : IGenericRepository<T> where T : class, IBaseEntity
    {
        private readonly SmsContext _dbContext;

        public Genericrepository(SmsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().SingleOrDefault(x => x.Id == id);
        }

        public T Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();

            return entity;
        }

        public T Update(T existing, T updated)
        {
            _dbContext.Entry(existing).CurrentValues.SetValues(@updated);
            _dbContext.SaveChanges();

            return existing;
        }

        public bool Delete(int id)
        {
            _dbContext.Set<T>().Remove(_dbContext.Set<T>().Single(x => x.Id == id));

            return true;
        }
    }
}
