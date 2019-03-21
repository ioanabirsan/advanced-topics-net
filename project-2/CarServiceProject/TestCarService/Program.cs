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
                Adresa = "Str. Palat",
                Email = "ioana@gmail.com",
                Nume = "Birsan",
                Prenume = "Ioana",
                Judet = "Iasi",
                Localitate = "Iasi",
                Telefon = "0040784043489"
            };
//            var clientId = carService.AddClient(client);

            var clientToUpdate = carService.FindClientByEmail("ioana@gmail.com");
            clientToUpdate.Judet = "Suceava";
//            carService.UpdateClient(clientToUpdate);

            var sasiu = new Sasiu()
            {
                CodSasiu = "4F",
                Denumire = "Sasiu Audi"
            };
            var sasiuId = carService.AddSasiu(sasiu);

            var auto = new Auto()
            {
                NumarAuto = "SV120COR",
                SerieSasiu = " WAUZZZ4FZ6A111222",
            };
//            var autoId = carService.AddAuto(auto, clientToUpdate.Id, sasiuId);

            var autoToUpdate = carService.FindAutoByNumarAuto("SV120COR");
            var detaliuComanda = new DetaliuComanda();

            var comanda = new Comanda()
            {
                DataProgramare = DateTime.Now,
                DataFinalizare = DateTime.Today,
                DataSystem = DateTime.UtcNow,
                Descriere = "Schimbare placute frana fata",
                KmBord = 10,
                ValoarePiese = 100m,
                DetaliuComanda = detaliuComanda
            };
//            var comandaId = carService.AddComanda(comanda, clientToUpdate.Id);
            
            carService.DeleteClient(clientToUpdate.Id);
//            carService.DeleteAuto(autoToUpdate.Id);
            var clients = carService.GetAllClients();
            foreach (var c in clients)
            {
                Console.WriteLine(c.Nume + " " +c.Prenume);
            }

        }
    }
}