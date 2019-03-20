using System;
using System.Collections.Generic;
using System.Linq;
using CarService.Repository.api;

namespace CarService.Repository.impl
{
    public class ImagineRepository : IRepository<Imagine>
    {
        private readonly CarServiceModelContainer _context;

        public ImagineRepository(CarServiceModelContainer context)
        {
            _context = context;
        }

        public Imagine GetById(int id)
        {
            return _context.Imagini.FirstOrDefault(i => i.Id == id);
        }

        public IReadOnlyList<Imagine> GetAll()
        {
            return _context.Imagini.ToList();
        }

        public void Create(Imagine imagine)
        {
            _context.Imagini.Add(imagine);
        }

        public void Delete(int id)
        {
            if (!Exists(id)) return;

            var imagine = _context.Imagini.First(i => i.Id == id);
            _context.Imagini.Remove(imagine);
            _context.SaveChanges();
        }

        public void Update(Imagine imagine)
        {
            var toUpdate = _context.Imagini.Find(imagine.Id);

            if (toUpdate == null) return;

            _context.Entry(toUpdate).CurrentValues.SetValues(imagine);
            _context.SaveChanges();
        }

        public bool Exists(int id)
        {
            return _context.Imagini.Any(i => i.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public Imagine FindByTitlu(string titlu)
        {
            return _context.Imagini.FirstOrDefault(i => i.Titlu == titlu);
        }
    }
}