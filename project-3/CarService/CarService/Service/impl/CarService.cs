/*
 * Nume si prenume: Birsan Ioana (cas. Amariei)
 * Laborator: Joi 12-14
 * Tema proiect: Car Service
 * Data predare proiect: 21.03.2019
 * Declaratie: Declar pe proprie raspundere ca acest proiect nu a fost copiat din alte surse
 * Bibliografie:
 * - https://blog.devart.com/set-identity-and-computed-properties-in-entity-framework-without-triggers.html
 * - https://stackoverflow.com/questions/25894587/how-to-update-record-using-entity-framework-6
 * - https://stackoverflow.com/questions/35799017/adding-attributes-to-ef6-generated-entity-classes
 * - http://alexwolfthoughts.com/adding-validation-metadata-to-entity-framework-generated-classes/
 * - https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/database-first-development/enhancing-data-validation
 */

using System;
using System.Collections.Generic;
using CarService.Repository.impl;
using CarService.Service.api;

namespace CarService.Service.impl
{
    public class CarService : ICarService
    {
        private readonly AutoRepository _autoRepository;
        private readonly ClientRepository _clientRepository;
        private readonly ComandaRepository _comandaRepository;
        private readonly DetaliuComandaRepository _detaliuComandaRepository;
        private readonly ImagineRepository _imagineRepository;
        private readonly MaterialRepository _materialRepository;
        private readonly MecanicRepository _mecanicRepository;
        private readonly OperatieRepository _operatieRepository;
        private readonly SasiuRepository _sasiuRepository;

        public CarService(AutoRepository autoRepository, ClientRepository clientRepository,
            ComandaRepository comandaRepository, DetaliuComandaRepository detaliuComandaRepository,
            ImagineRepository imagineRepository, MaterialRepository materialRepository,
            MecanicRepository mecanicRepository, OperatieRepository operatieRepository, SasiuRepository sasiuRepository)
        {
            _autoRepository = autoRepository;
            _clientRepository = clientRepository;
            _comandaRepository = comandaRepository;
            _detaliuComandaRepository = detaliuComandaRepository;
            _imagineRepository = imagineRepository;
            _materialRepository = materialRepository;
            _mecanicRepository = mecanicRepository;
            _operatieRepository = operatieRepository;
            _sasiuRepository = sasiuRepository;
        }

        public int AddClient(Client client)
        {
            if (client == null)
            {
                throw new ArgumentException("Client must not be null");
            }

            if (ExistsEmail(client.Email))
            {
                throw new ArgumentException("Email already exists.");
            }

            _clientRepository.Create(client);
            _clientRepository.SaveChanges();

            return client.Id;
        }

        private bool ExistsEmail(string email)
        {
            return _clientRepository.ContainsEmail(email);
        }

        public Client FindClientById(int id)
        {
            return _clientRepository.GetById(id);
        }

        public Client FindClientByName(string nume, string prenume)
        {
            if (string.IsNullOrEmpty(nume))
            {
                throw new ArgumentException("Nume must not be null or empty");
            }

            if (string.IsNullOrEmpty(prenume))
            {
                throw new ArgumentException("Prenume must not be null or empty");
            }

            return _clientRepository.FindByName(nume, prenume);
        }

        public Client FindClientByEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Email must not be null or empty");
            }

            return _clientRepository.FindByEmail(email);
        }

        public IReadOnlyList<Auto> GetClientAutos(int clientId)
        {
            return _clientRepository.GetAutos(clientId);
        }

        public IReadOnlyList<Comanda> GetClientOrders(int clientId)
        {
            return _clientRepository.GetOrders(clientId);
        }

        public IReadOnlyList<Client> GetAllClients()
        {
            return _clientRepository.GetAll();
        }

        public void DeleteClient(int id)
        {
            _clientRepository.Delete(id);
            _clientRepository.SaveChanges();
        }

        public int AddAuto(Auto auto, int clientId, int sasiuId)
        {
            if (auto == null)
            {
                throw new ArgumentException("Auto must not be null");
            }

            auto.ClientId = clientId;
            auto.SasiuId = sasiuId;

            _autoRepository.Create(auto);
            _autoRepository.SaveChanges();

            return auto.Id;
        }

        public Auto FindAutoById(int id)
        {
            return _autoRepository.GetById(id);
        }

        public Auto FindAutoBySerieSasiu(string serieSasiu)
        {
            return _autoRepository.FindBySerieSasiu(serieSasiu);
        }

        public Auto FindAutoByNumarAuto(string numarAuto)
        {
            return _autoRepository.FindByNumarAuto(numarAuto);
        }

        public IReadOnlyList<Comanda> GetAutoOrders(int autoId)
        {
            return _autoRepository.GetComenzi(autoId);
        }

        public IReadOnlyList<Auto> GetAllAutos()
        {
            return _autoRepository.GetAll();
        }

        public void UpdateAuto(Auto auto)
        {
            if (auto == null)
            {
                throw new ArgumentException("Auto must not be null.");
            } 

            _autoRepository.Update(auto);
        }

        public void DeleteAuto(int id)
        {
            _autoRepository.Delete(id);
            _autoRepository.SaveChanges();
        }

        public int AddSasiu(Sasiu sasiu)
        {
            if (sasiu == null)
            {
                throw new ArgumentException("Sasiu must not be null");
            }

            _sasiuRepository.Create(sasiu);
            _sasiuRepository.SaveChanges();

            return sasiu.Id;
        }

        public Sasiu FindSasiuById(int id)
        {
            return _sasiuRepository.GetById(id);
        }

        public Sasiu FindSasiuByCodSasiu(string codSasiu)
        {
            return _sasiuRepository.FindByCodSasiu(codSasiu);
        }

        public IReadOnlyList<Auto> GetSasiuAutos(int sasiuId)
        {
            return _sasiuRepository.GetAutos(sasiuId);
        }

        public void UpdateSasiu(Sasiu sasiu)
        {
            if (sasiu == null)
            {
                throw new ArgumentException("Sasiu must not be null.");
            }

            _sasiuRepository.Update(sasiu);
        }

        public void DeleteSasiu(int id)
        {
            _sasiuRepository.Delete(id);
        }

        public int AddMecanic(Mecanic mecanic, int detaliuComandaId)
        {
            if (mecanic == null)
            {
                throw new ArgumentException("Mecanic must not be null.");
            }

            mecanic.DetaliuComandaId = detaliuComandaId;
            _mecanicRepository.Create(mecanic);
            _mecanicRepository.SaveChanges();

            return mecanic.Id;
        }

        public Mecanic FindMecanicByName(string nume, string prenume)
        {
            return _mecanicRepository.FindByName(nume, prenume);
        }

        public Mecanic FindMecanicById(int id)
        {
            return _mecanicRepository.GetById(id);
        }

        public void UpdateMecanic(Mecanic mecanic)
        {
            if (mecanic == null)
            {
                throw new ArgumentException("Mecanic must not be null.");
            }

            _mecanicRepository.Update(mecanic);
        }

        public void DeleteMecanic(int id)
        {
            _mecanicRepository.Delete(id);
        }

        public int AddMaterial(Material material, int detaliuComandaId)
        {
            if (material == null)
            {
                throw new ArgumentException("Material must not be null.");
            }

            material.DetaliuComandaId = detaliuComandaId;
            _materialRepository.Create(material);
            _materialRepository.SaveChanges();

            return material.Id;
        }

        public Material FindMaterialByDenumire(string denumire)
        {
            if (string.IsNullOrEmpty(denumire))
            {
                throw new ArgumentException("Denumire must not be null.");
            }

            return _materialRepository.FindByDenumire(denumire);
        }

        public Material FindMaterialByCantitate(decimal cantitate)
        {
            return _materialRepository.FindByCantitate(cantitate);
        }

        public Material FindMaterialByPret(decimal pret)
        {
            return _materialRepository.FindByPret(pret);
        }

        public Material FindMaterialByDataAprovizionare(DateTime dataAprovizionare)
        {
            return _materialRepository.FindByDataAprovizionare(dataAprovizionare);
        }

        public void UpdateMaterial(Material material)
        {
            if (material == null)
            {
                throw new ArgumentException("Material must not be null.");
            }

            _materialRepository.Update(material);
        }

        public void DeleteMaterial(int id)
        {
            _materialRepository.Delete(id);
        }

        public int AddImagine(Imagine imagine, int detaliuComandaId)
        {
            if (imagine == null)
            {
                throw new ArgumentException("Imagine must not be null.");
            }

            imagine.DetaliuComandaId = detaliuComandaId;
            _imagineRepository.Create(imagine);
            _imagineRepository.SaveChanges();

            return imagine.Id;
        }

        public Imagine FindImagineByTitlu(string titlu)
        {
            if (string.IsNullOrEmpty(titlu))
            {
                throw  new ArgumentException("Titlu must not be null.");
            }
            return _imagineRepository.FindByTitlu(titlu);
        }

        public void UpdateImagine(Imagine imagine)
        {
            if (imagine == null)
            {
                throw new ArgumentException("Imagine must not be null.");
            }

            _imagineRepository.Update(imagine);
        }

        public void DeleteImagine(int id)
        {
            _imagineRepository.Delete(id);
        }

        public int AddOperatie(Operatie operatie, int detaliuComandaId)
        {
            if (operatie == null)
            {
                throw new ArgumentException("Operatie must not be null.");
            }

            operatie.DetaliuComandaId = detaliuComandaId;
            _operatieRepository.Create(operatie);
            _operatieRepository.SaveChanges();

            return operatie.Id;
        }

        public Operatie FindOperatieByTimpExecutie(decimal timpExecutie)
        {
            return _operatieRepository.FindByTimpExecutie(timpExecutie);
        }

        public void UpdateOperatie(Operatie operatie)
        {
            if (operatie == null)
            {
                throw new ArgumentException("Operatie must not be null.");
            }

            _operatieRepository.Update(operatie);
        }

        public void DeleteOperatie(int id)
        {
            _operatieRepository.Delete(id);
        }

        public int AddComanda(Comanda comanda, int clientId, int autoId)
        {
            if (comanda == null)
            {
                throw new ArgumentException("Comanda must not be null");
            }

            comanda.ClientId = clientId;
            comanda.AutoId = autoId;

            _comandaRepository.Create(comanda);
            _comandaRepository.SaveChanges();

            return comanda.Id;
        }

        public StareComanda GetStareComanda(int id)
        {
            return _comandaRepository.GetStare(id);
        }

        public Comanda FindComandaById(int id)
        {
            return _comandaRepository.GetById(id);
        }

        public Comanda FindComandaByDataFinalizare(DateTime data)
        {
            return _comandaRepository.FindByDataFinalizare(data);
        }

        public void UpdateComanda(Comanda comanda)
        {
            if (comanda == null)
            {
                throw new ArgumentException("Comanda must not be null.");
            }

            _comandaRepository.Update(comanda);
        }

        public void DeleteComanda(int id)
        {
            _comandaRepository.Delete(id);
        }

        public int AddDetaliuComanda(DetaliuComanda detaliuComanda)
        {
            if (detaliuComanda == null)
            {
                throw new ArgumentException("Detaliu comanda must not be null.");
            }

            _detaliuComandaRepository.Create(detaliuComanda);
            return detaliuComanda.Id;
        }

        public DetaliuComanda FindByComanda(int comandaId)
        {
            return _detaliuComandaRepository.FindByComanda(comandaId);
        }

        public IReadOnlyList<Mecanic> GetAllMechanicsForOrder(int orderId)
        {
            return _detaliuComandaRepository.GetMecanici(orderId);
        }

        public IReadOnlyList<Operatie> GetAllOperationsForOrder(int orderId)
        {
            return _detaliuComandaRepository.GetOperatii(orderId);
        }

        public IReadOnlyList<Imagine> GetAllImagesForOrder(int orderId)
        {
            return _detaliuComandaRepository.GetImagini(orderId);
        }

        public IReadOnlyList<Material> GetAllMaterialsForOrder(int orderId)
        {
            return _detaliuComandaRepository.GetMateriale(orderId);
        }

        public void UpdateDetaliuComanda(DetaliuComanda detaliuComanda)
        {
            if (detaliuComanda == null)
            {
                throw new ArgumentException("Detaliu comanda must not be null.");
            }

            _detaliuComandaRepository.Update(detaliuComanda);
        }

        public void DeleteDetaliuComanda(int id)
        {
            _detaliuComandaRepository.Delete(id);
        }

        public void UpdateClient(Client client)
        {
            if (client == null)
            {
                throw new ArgumentException("Client must not be null.");
            }
            _clientRepository.Update(client);
        }
    }
}