using System;
using System.Collections.Generic;
using System.Linq;
using CarService.Repository.api;

namespace CarService.Repository.impl
{
    public class MaterialRepository : IRepository<Material>
    {
        private readonly CarServiceModelContainer _context;

        public MaterialRepository(CarServiceModelContainer context)
        {
            _context = context;
        }

        public Material GetById(int id)
        {
            return _context.Materiale.FirstOrDefault(m => m.Id == id);
        }

        public IReadOnlyList<Material> GetAll()
        {
            return _context.Materiale.ToList();
        }

        public void Create(Material material)
        {
            _context.Materiale.Add(material);
        }

        public void Delete(int id)
        {
            if(!Exists(id)) return;

            var material = _context.Materiale.First(m => m.Id == id);
            _context.Materiale.Remove(material);
        }

        public void Update(Material material)
        {
            var toUpdate = _context.Materiale.Find(material.Id);

            if (toUpdate == null) return;

            _context.Entry(toUpdate).CurrentValues.SetValues(material);
            _context.SaveChanges();
        }

        public bool Exists(int id)
        {
            return _context.Materiale.Any(m => m.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
