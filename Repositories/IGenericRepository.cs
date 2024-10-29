using System.Collections.Generic;
using StudentManagementSystem.Models.Interfaces;

namespace StudentManagementSystem.Repositories
{
    public interface IGenericRepository<T> where T : class, IBaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Add(T newEntity);
        T Update(T existingEntity, T updatedEntity);
        bool Delete(int id);
    }
}
