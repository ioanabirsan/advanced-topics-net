using System;
using System.Collections.Generic;
using System.Linq;

namespace CarService.Api
{
    public class CarServiceApi
    {
        private readonly CarServiceModelContainer _context;

        public CarServiceApi()
        {
            _context = new CarServiceModelContainer();
        }

        public Client FindCustomer(string nume, string prenume, string email)
        {
            if (string.IsNullOrEmpty(nume))
            {
                throw new ArgumentException("Nume must not be null or empty.");
            }

            if (string.IsNullOrEmpty(prenume))
            {
                throw new ArgumentException("Prenume must not be null or empty.");
            }
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Email must not be null or empty.");
            }

            Client client = _context.Clienti.FirstOrDefault(c =>
                c.Nume.Equals(nume) && c.Prenume.Equals(prenume) && c.Email.Equals(email));

            return client;
        }

        public void AddCustomer(Client client)
        {
            if (client == null)
            {
                throw new ArgumentException("Client must not be null.");
            }

            _context.Clienti.Add(client);
            _context.SaveChanges();
        }

        public List<Client> GetAllCustomers()
        {
            return _context.Clienti.ToList();
        }

        public void AddChassis(Sasiu sasiu)
        {
            if (sasiu == null)
            {
                throw new ArgumentException("Sasiu must not be null.");
            }

            _context.Sasiuri.Add(sasiu);
            _context.SaveChanges();
        }
    }
}
