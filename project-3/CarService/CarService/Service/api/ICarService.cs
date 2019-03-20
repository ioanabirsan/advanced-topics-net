using System.Collections.Generic;

namespace CarService.Service.api
{
    public interface ICarService
    {
        int AddClient(Client client);
        Client FindByName(string nume, string prenume);
        Client FindByEmail(string email);
        IReadOnlyList<Auto> GetClientAutos(int clientId);

        int AddAuto(Auto auto, int clientId, int sasiuId);
        int AddSasiu(Sasiu sasiu);
        int AddComanda(Comanda comanda, int clientId, int autoId);
        void Update(int id, Client client);
    }
}
