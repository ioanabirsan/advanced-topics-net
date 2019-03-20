using System;
using CarService;
using CarService.Repository.impl;
using CarService.Service.api;


namespace TestCarService
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");

            var context = new CarServiceModelContainer();
            var autoRepository = new AutoRepository(context);
            var clientRepository = new ClientRepository(context);
            var comandaRepository = new ComandaRepository(context);
            var detaliuComandaRepository = new DetaliuComandaRepository(context);
            var imagineRepository = new ImagineRepository(context);
            var materialRepository = new MaterialRepository(context);
            var mecanicRepository = new MecanicRepository(context);
            var operatieRepository = new OperatieRepository(context);
            var sasiuRepository = new SasiuRepository(context);

            ICarService carService = new CarService.Service.impl.CarService(autoRepository, clientRepository,
                comandaRepository, detaliuComandaRepository, imagineRepository, materialRepository, mecanicRepository,
                operatieRepository, sasiuRepository);

            var client = new Client()
            {
                Adresa = "Adresa123",
                Email = "test4@test.com",
                Nume = "Test",
                Prenume = "test",
                Judet = "Iasi",
                Localitate = "Iasi",
                Telefon = "0407893453347"
            };
            var clientId = carService.AddClient(client);

//            client.Adresa = "eunjsk";
//            carService.UpdateClient(client);

            var sasiu = new Sasiu()
            {
                CodSasiu = "4F",
                Denumire = "TestSasiu"
            };
            var sasiuId = carService.AddSasiu(sasiu);

            var auto = new Auto()
            {
                NumarAuto = "3y5y8y4",
                SerieSasiu = "64372",
            };
            var autoId = carService.AddAuto(auto, clientId, sasiuId);

            var clientToUpdate = carService.FindClientByEmail("test4@test.com");
            clientToUpdate.Judet = "Suceava";
            carService.UpdateClient(clientToUpdate);

            var detaliuComanda = new DetaliuComanda();

            var comanda = new Comanda()
            {
                DataProgramare = DateTime.Now,
                DataFinalizare = DateTime.Today,
                DataSystem = DateTime.UtcNow,
                Descriere = "test-descriere",
                KmBord = 10,
                ValoarePiese = 10m,
                DetaliuComanda = detaliuComanda
            };
            var comandaId = carService.AddComanda(comanda, clientId, autoId);
            
//            carService.DeleteSasiu(sasiuId);
//            carService.DeleteClient(clientId);
//            carService.DeleteAuto(autoId);
//            carService.DeleteComanda(comandaId);

            var clients = carService.GetAllClients();
            foreach (var c in clients)
            {
                Console.WriteLine(c.Nume + " " +c.Prenume);
            }

        }
    }
}