namespace CarService.Service.api
{
    public interface ICarService
    {
        int AddClient(Client client);
        int AddAuto(Auto auto, int clientId, int sasiuId);
        int AddSasiu(Sasiu sasiu);
        int AddComanda(Comanda comanda, int clientId, int autoId);
    }
}
