using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using CarService.Repository.api;

namespace CarService.Repository.impl
{
    public class AutoRepository : IRepository<Auto>
    {
        private readonly CarServiceModelContainer _context;

        public AutoRepository(CarServiceModelContainer context)
        {
            _context = context;
        }

        public Auto GetById(int id)
        {
            return _context.Automobile.FirstOrDefault(auto => auto.Id == id);
        }

        public IReadOnlyList<Auto> GetAll()
        {
            return _context.Automobile.ToList();
        }

        public void Create(Auto auto)
        {
            _context.Automobile.Add(auto);
        }

        public void Delete(int id)
        {
            if(!Exists(id)) return;

            var auto = _context.Automobile.First(a => a.Id == id);
            _context.Automobile.Remove(auto);
        }

        public void Update(Auto auto)
        {
            var toUpdate = _context.Automobile.Find(auto.Id);

            if (toUpdate == null) return;

            _context.Entry(toUpdate).CurrentValues.SetValues(auto);
            _context.SaveChanges();
        }

        public bool Exists(int id)
        {
            return _context.Automobile.Any(auto => auto.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
