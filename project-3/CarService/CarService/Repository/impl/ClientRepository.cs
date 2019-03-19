using System.Collections.Generic;
using System.Linq;
using CarService.Repository.api;

namespace CarService.Repository.impl
{
    public class ClientRepository : IRepository<Client>
    {
        private readonly CarServiceModelContainer _context;

        public ClientRepository(CarServiceModelContainer context)
        {
            _context = context;
        }

        public Client GetById(int id)
        {
            return _context.Clienti.FirstOrDefault(c => c.Id == id);
        }

        public IReadOnlyList<Client> GetAll()
        {
            return _context.Clienti.ToList();
        }

        public void Create(Client client)
        {
            _context.Clienti.Add(client);
        }

        public void Delete(int id)
        {
            if (!Exists(id)) return;

            var client = _context.Clienti.First(c => c.Id == id);
            _context.Clienti.Remove(client);
        }

        public void Update(int id, Client client)
        {
            if (client == null) return;

            if (!Exists(id)) return;

            var clientToUpdate = _context.Clienti.First(c => c.Id == id);
            clientToUpdate.Nume = client.Nume;
            clientToUpdate.Prenume = client.Prenume;
            clientToUpdate.Adresa = client.Adresa;
            clientToUpdate.Localitate = client.Localitate;
            clientToUpdate.Judet = client.Judet;
            clientToUpdate.Email = client.Email;
            clientToUpdate.Telefon = client.Telefon;

            _context.SaveChanges();
        }

        public bool Exists(int id)
        {
            return _context.Clienti.Any(c => c.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}