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

        public void Update(Client client)
        {
            var toUpdate = _context.Clienti.Find(client.Id);

            if (toUpdate == null) return;

            _context.Entry(toUpdate).CurrentValues.SetValues(client);
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

        public Client FindByName(string nume, string prenume)
        {
            return _context.Clienti.FirstOrDefault(c => c.Nume == nume && c.Prenume == prenume);
        }

        public Client FindByEmail(string email)
        {
            return _context.Clienti.FirstOrDefault(c => c.Email == email);
        }

        public IReadOnlyList<Auto> GetAutos(int id)
        {
            if (!Exists(id)) return null;

            var client = _context.Clienti.First(c => c.Id == id);
            return client.Automobile.ToList();
        }
    }
}