using System;
using System.Collections.Generic;
using System.Linq;
using CarService.Repository.api;

namespace CarService.Repository.impl
{
    public class OperatieRepository : IRepository<Operatie>
    {
        private readonly CarServiceModelContainer _context;

        public OperatieRepository(CarServiceModelContainer context)
        {
            _context = context;
        }

        public Operatie GetById(int id)
        {
            return _context.Operatii.FirstOrDefault(o => o.Id == id);
        }

        public IReadOnlyList<Operatie> GetAll()
        {
            return _context.Operatii.ToList();
        }

        public void Create(Operatie operatie)
        {
            _context.Operatii.Add(operatie);
        }

        public void Delete(int id)
        {
            if (!Exists(id)) return;

            var operatie = _context.Operatii.First(o => o.Id == id);
            _context.Operatii.Remove(operatie);
        }

        public void Update(int id, Operatie operatie)
        {
            if (operatie == null) return;

            if (!Exists(id)) return;

            var toUpdate = _context.Operatii.First(o => o.Id == id);
            toUpdate.Denumire = operatie.Denumire;
            toUpdate.TimpExecutie = operatie.TimpExecutie;
         
            _context.SaveChanges();
        }

        public bool Exists(int id)
        {
            return _context.Operatii.Any(o => o.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
