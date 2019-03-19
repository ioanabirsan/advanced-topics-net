/*
 * Nume si prenume: Birsan Ioana (cas. Amariei)
 * Laborator: Joi 12-14
 * Tema proiect: Car Service
 * Data predare proiect: 21.03.2019
 * Declaratie: Declar pe proprie raspundere ca acest proiect nu a fost copiat din alte surse
 * Bibliografie:
 * - https://blog.devart.com/set-identity-and-computed-properties-in-entity-framework-without-triggers.html
 * - https://stackoverflow.com/questions/25894587/how-to-update-record-using-entity-framework-6
 * - https://stackoverflow.com/questions/25894587/how-to-update-record-using-entity-framework-6
 */

using System;
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

        public CarService(AutoRepository autoRepository, ClientRepository clientRepository, ComandaRepository comandaRepository, DetaliuComandaRepository detaliuComandaRepository, ImagineRepository imagineRepository, MaterialRepository materialRepository, MecanicRepository mecanicRepository, OperatieRepository operatieRepository, SasiuRepository sasiuRepository)
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

            _clientRepository.Create(client);
            _clientRepository.SaveChanges();

            return client.Id;
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
    }
}