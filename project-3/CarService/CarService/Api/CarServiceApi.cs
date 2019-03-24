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

        public Sasiu FindChassisByCode(string chassisCode)
        {
            if (string.IsNullOrEmpty(chassisCode))
            {
                throw new ArgumentException("Chassis code must not be null or empty.");
            }

            return _context.Sasiuri.FirstOrDefault(s => s.CodSasiu.Equals(chassisCode));
        }

        public void AddAuto(Auto auto)
        {
            if (auto == null)
            {
                throw new ArgumentException("Auto must not be null.");
            }

            _context.Automobile.Add(auto);
            _context.SaveChanges();
        }

        public void AddMaterial(Material material)
        {
            if (material == null)
            {
                throw new ArgumentException("Material must not be null.");
            }

            _context.Materiale.Add(material);
            _context.SaveChanges();
        }

        public void AddOrder(Comanda comanda)
        {
            if (comanda == null)
            {
                throw new ArgumentException("Comanda must not be null.");
            }

            _context.Comenzi.Add(comanda);
            _context.SaveChanges();
        }

        public void AddOperation(Operatie operation)
        {
            if (operation == null)
            {
                throw new ArgumentException("Operation must not be null.");
            }

            _context.Operatii.Add(operation);
            _context.SaveChanges();
        }

        public void AddMechnic(Mecanic mechanic)
        {
            if (mechanic == null)
            {
                throw new ArgumentException("Mechnic must not be null.");
            }

            _context.Mecanici.Add(mechanic);
            _context.SaveChanges();
        }

        public void AddImage(Imagine image)
        {
            if (image == null)
            {
                throw new ArgumentException("Image must not be null.");
            }

            _context.Imagini.Add(image);
            _context.SaveChanges();
        }
    }
}
