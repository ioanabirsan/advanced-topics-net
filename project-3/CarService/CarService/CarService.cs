/*
 * Nume si prenume: Birsan Ioana (cas. Amariei)
 * Laborator: Joi 12-14
 * Tema proiect: Car Service
 * Data predare proiect: 21.03.2019
 * Declaratie: Declar pe proprie raspundere ca acest proiect nu a fost copiat din alte surse
 * Bibliografie:
 */


using System.Collections.Generic;
using CarServiceProject.Repository;

namespace CarServiceProject
{
    public class CarService
    {
        private readonly IAutoRepository _autoRepository;

        public CarService(IAutoRepository autoRepository)
        {
            _autoRepository = autoRepository;
        }

        public void CreateAuto(Auto auto)
        {
            _autoRepository.Create(auto);
            _autoRepository.SaveChanges();
        }

        public IReadOnlyList<Auto> GetAll()
        {
            return _autoRepository.GetAll();
        }
    }
}