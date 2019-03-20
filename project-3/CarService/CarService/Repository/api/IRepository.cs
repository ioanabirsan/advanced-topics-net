using System.Collections.Generic;

namespace CarService.Repository.api
{
    public interface IRepository<T>
    {
        T GetById(int id);
        IReadOnlyList<T> GetAll();
        void Create(T item);
        void Delete(int id);
        void Update(T item);
        bool Exists(int id);
        void SaveChanges();
    }
}