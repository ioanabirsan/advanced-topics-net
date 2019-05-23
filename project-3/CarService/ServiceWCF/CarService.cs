using System.Collections.Generic;
using CarService;
using CarService.Api;

namespace ServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CarService : ICarService
    {
        private readonly CarServiceApi _api;

        public CarService()
        {
            _api = new CarServiceApi();
        }

        public Client FindCustomer(string nume, string prenume, string phoneNumber)
        {
            return _api.FindCustomer(nume, prenume, phoneNumber);
        }

        public void AddCustomer(Client client)
        {
            _api.AddCustomer(client);
        }

        public List<Client> GetAllCustomers()
        {
            return _api.GetAllCustomers();
        }

        public void AddChassis(Sasiu sasiu)
        {
            _api.AddChassis(sasiu);
        }

        public Sasiu FindChassisByCode(string chassisCode)
        {
            return _api.FindChassisByCode(chassisCode);
        }

        public void AddAuto(Auto auto)
        {
            _api.AddAuto(auto);
        }

        public void AddMaterial(Material material)
        {
            _api.AddMaterial(material);
        }

        public void AddOrder(Comanda comanda)
        {
            _api.AddOrder(comanda);
        }

        public void AddOperation(Operatie operation)
        {
            _api.AddOperation(operation);
        }

        public void AddMecanic(Mecanic mecanic)
        {
            _api.AddMecanic(mecanic);
        }

        public void AddImage(Imagine image)
        {
            _api.AddImage(image);
        }

        public void UpdateClient(Client client)
        {
            _api.UpdateClient(client);
        }

        public void UpdateOrder(Comanda order)
        {
            _api.UpdateOrder(order);
        }

        public Comanda FindOrderById(int id)
        {
            return _api.FindOrderById(id);
        }

        public Client FindCustomerById(int id)
        {
            return _api.FindCustomerById(id);
        }

        public void DeleteClient(int id)
        {
            _api.DeleteClient(id);
        }

        public bool ExistsClient(int id)
        {
            return _api.ExistsClient(id);
        }

        public void DeleteOrder(int id)
        {
            _api.DeleteOrder(id);
        }

        public Material FindMaterialById(int id)
        {
            return _api.FindMaterialById(id);
        }

        public Operatie FindOperationById(int id)
        {
            return _api.FindOperationById(id);
        }

        public Mecanic FindMecanicById(int id)
        {
            return _api.FindMecanicById(id);
        }

        public Imagine FindImageById(int id)
        {
            return _api.FindImageById(id);
        }

        public void AddOrderDetails(DetaliuComanda orderDetails)
        {
            _api.AddOrderDetails(orderDetails);
        }

        public Sasiu FindChassisById(int id)
        {
            return _api.FindChassisById(id);
        }

        public void UpdateChassis(Sasiu chassis)
        {
            _api.UpdateChassis(chassis);
        }

        public void DeleteChassis(int id)
        {
            _api.DeleteChassis(id);
        }

        public void UpdateMecanic(Mecanic mecanic)
        {
            _api.UpdateMecanic(mecanic);
        }

        public void DeleteMecanic(int id)
        {
            _api.DeleteMecanic(id);
        }

        public void UpdateImage(Imagine image)
        {
            _api.UpdateImage(image);
        }

        public void DeleteImage(int id)
        {
            _api.DeleteImage(id);
        }

        public void UpdateMaterial(Material material)
        {
            _api.UpdateMaterial(material);
        }

        public void DeleteMaterial(int id)
        {
            _api.DeleteMaterial(id);
        }

        public void UpdateOperation(Operatie operation)
        {
            _api.UpdateOperation(operation);
        }

        public void DeleteOperation(int id)
        {
            _api.DeleteOperation(id);
        }

        public bool ExistsCustomer(string email)
        {
            return _api.ExistsCustomer(email);
        }
    }
}
