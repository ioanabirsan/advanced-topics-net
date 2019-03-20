using System.Collections.Generic;
using System.Linq;
using CarService.Repository.api;

namespace CarService.Repository.impl
{
    public class MecanicRepository : IRepository<Mecanic>
    {
        private readonly CarServiceModelContainer _context;

        public MecanicRepository(CarServiceModelContainer context)
        {
            _context = context;
        }

        public Mecanic GetById(int id)
        {
            return _context.Mecanici.FirstOrDefault(m => m.Id == id);
        }

        public IReadOnlyList<Mecanic> GetAll()
        {
            return _context.Mecanici.ToList();
        }

        public void Create(Mecanic mecanic)
        {
            _context.Mecanici.Add(mecanic);
        }

        public void Delete(int id)
        {
            if(!Exists(id)) return;

            var mecanic = _context.Mecanici.First(m => m.Id == id);
            _context.Mecanici.Remove(mecanic);
        }

        public void Update(Mecanic mecanic)
        {
            var toUpdate = _context.Mecanici.Find(mecanic.Id);

            if (toUpdate == null) return;

            _context.Entry(toUpdate).CurrentValues.SetValues(mecanic);
            _context.SaveChanges();
        }

        public bool Exists(int id)
        {
            return _context.Mecanici.Any(m => m.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
