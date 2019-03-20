using System.Collections.Generic;
using System.Linq;
using CarService.Repository.api;

namespace CarService.Repository.impl
{
    public class SasiuRepository : IRepository<Sasiu>
    {
        private readonly CarServiceModelContainer _context;

        public SasiuRepository(CarServiceModelContainer context)
        {
            _context = context;
        }

        public Sasiu GetById(int id)
        {
            return _context.Sasiuri.FirstOrDefault(s => s.Id == id);
        }

        public IReadOnlyList<Sasiu> GetAll()
        {
            return _context.Sasiuri.ToList();
        }

        public void Create(Sasiu sasiu)
        {
            _context.Sasiuri.Add(sasiu);
        }

        public void Delete(int id)
        {
            if (!Exists(id)) return;

            var sasiu = _context.Sasiuri.First(s => s.Id == id);
            _context.Sasiuri.Remove(sasiu);
        }

        public void Update(Sasiu sasiu)
        {
            var toUpdate = _context.Sasiuri.Find(sasiu.Id);

            if (toUpdate == null) return;

            _context.Entry(toUpdate).CurrentValues.SetValues(sasiu);
            _context.SaveChanges();
        }

        public bool Exists(int id)
        {
            return _context.Sasiuri.Any(s => s.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}