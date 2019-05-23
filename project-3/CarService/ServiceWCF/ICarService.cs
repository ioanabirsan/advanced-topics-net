using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CarService;

namespace ServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICarService
    {
        [OperationContract]
        Client FindCustomer(string nume, string prenume, string phoneNumber);

        [OperationContract]
        void AddCustomer(Client client);

        [OperationContract]
        List<Client> GetAllCustomers();

        [OperationContract]
        void AddChassis(Sasiu sasiu);

        [OperationContract]
        Sasiu FindChassisByCode(string chassisCode);

        [OperationContract]
        void AddAuto(Auto auto);

        [OperationContract]
        void AddMaterial(Material material);

        [OperationContract]
        void AddOrder(Comanda comanda);

        [OperationContract]
        void AddOperation(Operatie operation);

        [OperationContract]
        void AddMecanic(Mecanic mecanic);

        [OperationContract]
        void AddImage(Imagine image);

        [OperationContract]
        void UpdateClient(Client client);

        [OperationContract]
        void UpdateOrder(Comanda order);

        [OperationContract]
        Comanda FindOrderById(int id);

        [OperationContract]
        Client FindCustomerById(int id);

        [OperationContract]
        void DeleteClient(int id);

        [OperationContract]
        bool ExistsClient(int id);

        [OperationContract]
        void DeleteOrder(int id);

        [OperationContract]
        Material FindMaterialById(int id);

        [OperationContract]
        Operatie FindOperationById(int id);

        [OperationContract]
        Mecanic FindMecanicById(int id);

        [OperationContract]
        Imagine FindImageById(int id);

        [OperationContract]
        void AddOrderDetails(DetaliuComanda orderDetails);

        [OperationContract]
        Sasiu FindChassisById(int id);

        [OperationContract]
        void UpdateChassis(Sasiu chassis);

        [OperationContract]
        void DeleteChassis(int id);

        [OperationContract]
        void UpdateMecanic(Mecanic mecanic);

        [OperationContract]
        void DeleteMecanic(int id);

        [OperationContract]
        void UpdateImage(Imagine image);

        [OperationContract]
        void DeleteImage(int id);

        [OperationContract]
        void UpdateMaterial(Material material);

        [OperationContract]
        void DeleteMaterial(int id);

        [OperationContract]
        void UpdateOperation(Operatie operation);

        [OperationContract]
        void DeleteOperation(int id);

        [OperationContract]
        bool ExistsCustomer(string email);
    }

}
