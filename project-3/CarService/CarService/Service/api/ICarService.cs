using System.Collections.Generic;
using System.Globalization;

namespace CarService.Service.api
{
    public interface ICarService
    {
        int AddClient(Client client);
        Client FindClientById(int id);
        Client FindClientByName(string nume, string prenume);
        Client FindClientByEmail(string email);
        IReadOnlyList<Auto> GetClientAutos(int clientId);
        IReadOnlyList<Comanda> GetClientOrders(int clientId);
        IReadOnlyList<Client> GetAllClients();
        void UpdateClient(Client client);
        void DeleteClient(int id);

        int AddAuto(Auto auto, int clientId, int sasiuId);
        Auto FindAutoById(int id);
        Auto FindAutoBySerieSasiu(string serieSasiu);
        Auto FindAutoByNumarAuto(string numarAuto);
        IReadOnlyList<Comanda> GetAutoOrders(int autoId);
        IReadOnlyList<Auto> GetAllAutos();
        void UpdateAuto(Auto auto);
        void DeleteAuto(int id);

        int AddSasiu(Sasiu sasiu);
        Sasiu FindSasiuById(int id);
        Sasiu FindSasiuByCodSasiu(string codSasiu);
        IReadOnlyList<Auto> GetSasiuAutos(int sasiuId);
        void UpdateSasiu(Sasiu sasiu);
        void DeleteSasiu(int id);

        int AddMecanic(Mecanic mecanic, int detaliuComandaId);
        Mecanic FindMecanicByName(string nume, string prenume);
        Mecanic FindMecanicById(int id);
        void UpdateMecanic(Mecanic mecanic);
        void DeleteMecanic(int id);

        int AddMaterial(Material material, int detaliuComandaId);
        Material FindMaterialByDenumire(string denumire);
        Material FindMaterialByCantitate(decimal cantitate);
        Material FindMaterialByPret(decimal pret);
        Material FindMaterialByDataAprovizionare(System.DateTime dataAprovizionare);
        void UpdateMaterial(Material material);
        void DeleteMaterial(int id);

        int AddImagine(Imagine imagine, int detaliuComandaId);
        Imagine FindImagineByTitlu(string titlu);
        Imagine FindImagineByData(System.DateTime data);
        void UpdateImagine(Imagine imagine);
        void DeleteImagine(int id);

        int AddOperatie(Operatie operatie, int detaliuComandaId);
        Operatie FindOperatieByTimpExecutie(decimal timpExecutie);
        void UpdateOperatie(Operatie operatie);
        void DeleteOperatie(int id);

        int AddComanda(Comanda comanda, int clientId, int autoId);
        
    }
}
