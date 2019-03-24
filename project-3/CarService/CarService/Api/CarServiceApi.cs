using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace CarService.Api
{
    public class CarServiceApi
    {
        private readonly CarServiceModelContainer _context;

        private string connectionString =
            @"Data source=localhost\SQLEXPRESS; Initial Catalog=AUTO; Integrated Security=True";

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

        public void AddMecanic(Mecanic mecanic)
        {
            if (mecanic == null)
            {
                throw new ArgumentException("Mecanic must not be null.");
            }

            _context.Mecanici.Add(mecanic);
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

        public void UpdateClient(Client client)
        {
            if (client == null)
            {
                throw new ArgumentException("Client must not be null.");
            }

            var toUpdate = _context.Clienti.Find(client.Id);
            if (toUpdate == null) return;

            _context.Entry(toUpdate).CurrentValues.SetValues(client);
            _context.SaveChanges();
        }

        public void UpdateOrder(Comanda order)
        {
            if (order == null)
            {
                throw new ArgumentException("Order must not be null.");
            }

            var toUpdate = _context.Comenzi.Find(order.Id);
            if (toUpdate == null) return;

            _context.Entry(toUpdate).CurrentValues.SetValues(order);
            _context.SaveChanges();
        }

        public Comanda FindOrderById(int id)
        {
            return _context.Comenzi.Find(id);
        }

        public Client FindCustomerById(int id)
        {
            return _context.Clienti.Find(id);
        }

        public void DeleteClient(int id)
        {
            if (!ExistsClient(id)) return;

            var client = _context.Clienti.First(c => c.Id == id);

            _context.Clienti.Remove(client);
            _context.SaveChanges();
        }

        public bool ExistsClient(int id)
        {
            return _context.Clienti.Any(c => c.Id == id);
        }

        public void DeleteOrder(int id)
        {
            if (!ExistsOrder(id)) return;

            var order = _context.Comenzi.First(c => c.Id == id);

            DetaliuComanda detaliuComanda = _context.DetaliiComenzi.FirstOrDefault(c => c.ComandaId == order.Id);
            if (detaliuComanda == null) return;

            ExecuteQuery($"DELETE FROM MaterialDetaliuComanda WHERE DetaliiComenzi_Id = {detaliuComanda.Id};");
            ExecuteQuery($"DELETE FROM ImagineDetaliuComanda WHERE DetaliiComenzi_Id = {detaliuComanda.Id};");
            ExecuteQuery($"DELETE FROM MecanicDetaliuComanda WHERE DetaliiComenzi_Id = {detaliuComanda.Id};");
            ExecuteQuery($"DELETE FROM OperatieDetaliuComanda WHERE DetaliiComenzi_Id = {detaliuComanda.Id};");

            detaliuComanda.Materiale.Clear();
            detaliuComanda.Imagini.Clear();
            detaliuComanda.Mecanici.Clear();
            detaliuComanda.Operatii.Clear();
            
            _context.Comenzi.Remove(order);
            _context.SaveChanges();
        }

        private void ExecuteQuery(string sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public Material FindMaterialById(int id)
        {
            return _context.Materiale.Find(id);
        }

        public Operatie FindOperationById(int id)
        {
            return _context.Operatii.Find(id);
        }

        public Mecanic FindMecanicById(int id)
        {
            return _context.Mecanici.Find(id);
        }

        public Imagine FindImageById(int id)
        {
            return _context.Imagini.Find(id);
        }

        public void AddOrderDetails(DetaliuComanda orderDetails)
        {
            _context.DetaliiComenzi.Add(orderDetails);
            _context.SaveChanges();
        }

        public Sasiu FindChassisById(int id)
        {
            return _context.Sasiuri.Find(id);
        }

        public void UpdateChassis(Sasiu chassis)
        {
            if (chassis == null)
            {
                throw new ArgumentException("Chassis must not be null.");
            }

            var toUpdate = _context.Sasiuri.Find(chassis.Id);
            if (toUpdate == null) return;

            _context.Entry(toUpdate).CurrentValues.SetValues(chassis);
            _context.SaveChanges();
        }

        public void DeleteChassis(int id)
        {
            if (!ExistsChassis(id)) return;

            var chassis = _context.Sasiuri.First(c => c.Id == id);

            _context.Sasiuri.Remove(chassis);
            _context.SaveChanges();
        }

        private bool ExistsChassis(int id)
        {
            return _context.Sasiuri.Any(c => c.Id == id);
        }

        private bool ExistsOrder(int id)
        {
            return _context.Comenzi.Any(c => c.Id == id);
        }

        public void UpdateMecanic(Mecanic mecanic)
        {
            if (mecanic == null)
            {
                throw new ArgumentException("Mecanic must not be null.");
            }

            var toUpdate = _context.Mecanici.Find(mecanic.Id);
            if (toUpdate == null) return;

            _context.Entry(toUpdate).CurrentValues.SetValues(mecanic);
            _context.SaveChanges();
        }

        public void DeleteMecanic(int id)
        {
            if (!ExistsMecanic(id)) return;

            var mecanic = _context.Mecanici.First(c => c.Id == id);
            ExecuteQuery($"DELETE FROM MecanicDetaliuComanda WHERE Mecanici_Id = {mecanic.Id};");

            _context.Mecanici.Remove(mecanic);
            _context.SaveChanges();
        }

        private bool ExistsMecanic(int id)
        {
            return _context.Mecanici.Any(c => c.Id == id);
        }

        public void UpdateImage(Imagine image)
        {
            if (image == null)
            {
                throw new ArgumentException("Image must not be null.");
            }

            var toUpdate = _context.Imagini.Find(image.Id);
            if (toUpdate == null) return;

            _context.Entry(toUpdate).CurrentValues.SetValues(image);
            _context.SaveChanges();
        }

        public void DeleteImage(int id)
        {
            if (!ExistsImage(id)) return;

            var image = _context.Imagini.First(c => c.Id == id);

            ExecuteQuery($"DELETE FROM ImagineDetaliuComanda WHERE Imagini_Id = {image.Id};");
            
            _context.Imagini.Remove(image);
            _context.SaveChanges();
        }

        private bool ExistsImage(int id)
        {
            return _context.Imagini.Any(c => c.Id == id);
        }

        public void UpdateMaterial(Material material)
        {
            if (material == null)
            {
                throw new ArgumentException("Material must not be null.");
            }

            var toUpdate = _context.Materiale.Find(material.Id);
            if (toUpdate == null) return;

            _context.Entry(toUpdate).CurrentValues.SetValues(material);
            _context.SaveChanges();
        }

        public void DeleteMaterial(int id)
        {
            if (!ExistsMaterial(id)) return;

            var material = _context.Materiale.First(c => c.Id == id);

            ExecuteQuery($"DELETE FROM MaterialDetaliuComanda WHERE Materiale_Id = {material.Id};");

            _context.Materiale.Remove(material);
            _context.SaveChanges();
        }

        private bool ExistsMaterial(int id)
        {
            return _context.Materiale.Any(c => c.Id == id);
        }

        public void UpdateOperation(Operatie operation)
        {
            if (operation == null)
            {
                throw new ArgumentException("Operation must not be null.");
            }

            var toUpdate = _context.Operatii.Find(operation.Id);
            if (toUpdate == null) return;

            _context.Entry(toUpdate).CurrentValues.SetValues(operation);
            _context.SaveChanges();
        }

        public void DeleteOperation(int id)
        {
            if (!ExistsOperation(id)) return;

            var operation = _context.Operatii.First(c => c.Id == id);

            ExecuteQuery($"DELETE FROM OperatieDetaliuComanda WHERE Operatii_Id = {operation.Id};");

            _context.Operatii.Remove(operation);
            _context.SaveChanges();
        }

        private bool ExistsOperation(int id)
        {
            return _context.Operatii.Any(c => c.Id == id);
        }

        public bool ExistsCustomer(string email)
        {
            Client client = _context.Clienti.FirstOrDefault(c => c.Email.Equals(email));
            return client != null;
        }
    }
}