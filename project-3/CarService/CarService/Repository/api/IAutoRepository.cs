using System.Collections.Generic;

namespace CarService.Repository.api
{
    public interface IAutoRepository
    {
        Auto GetById(int id);
        IReadOnlyList<Auto> GetAll();
        void Create(Auto auto);
        void Delete(int id);
        void Update(int id, Auto auto);
        bool Exists(int id);
        void SaveChanges();
    }
}
