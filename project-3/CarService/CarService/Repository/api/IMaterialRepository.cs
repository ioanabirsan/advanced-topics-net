using System.Collections.Generic;

namespace CarService.Repository.api
{
    public interface IMaterialRepository
    {
        Material GetById(int id);
        IReadOnlyList<Material> GetAll();
        void Create(Material material);
        void Delete(int id);
        void Update(int id, Material material);
        bool Exists(int id);
        void SaveChanges();
    }
}
