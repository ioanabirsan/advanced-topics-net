using System.Collections.Generic;

namespace CarService.Repository.api
{
    public interface IClientRepository
    {
        Client GetById(int id);
        IReadOnlyList<Client> GetAll();
        void Create(Client client);
        void Delete(int id);
        void Update(int id, Client client);
        bool Exists(int id);
        void SaveChanges();
    }
}
