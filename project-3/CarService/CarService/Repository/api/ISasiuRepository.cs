using System.Collections.Generic;

namespace CarService.Repository.api
{
    public interface ISasiuRepository
    {
        Sasiu GetById(int id);
        IReadOnlyList<Sasiu> GetAll();
        void Create(Sasiu sasiu);
        void Delete(int id);
        void Update(int id, Sasiu sasiu);
        bool Exists(int id);
        void SaveChanges();
    }
}
