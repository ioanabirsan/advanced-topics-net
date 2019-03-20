using System;
using System.Collections.Generic;
using System.Linq;
using CarService.Repository.api;

namespace CarService.Repository.impl
{
    public class ComandaRepository : IRepository<Comanda>
    {
        private readonly CarServiceModelContainer _context;

        public ComandaRepository(CarServiceModelContainer context)
        {
            _context = context;
        }

        public Comanda GetById(int id)
        {
            return _context.Comenzi.FirstOrDefault(c => c.Id == id);
        }

        public IReadOnlyList<Comanda> GetAll()
        {
            return _context.Comenzi.ToList();
        }

        public void Create(Comanda comanda)
        {
            _context.Comenzi.Add(comanda);
        }

        public void Delete(int id)
        {
            if (!Exists(id)) return;

            var comanda = _context.Comenzi.First(c => c.Id == id);
            _context.Comenzi.Remove(comanda);
            _context.SaveChanges();
        }

        public void Update(Comanda comanda)
        {
            var toUpdate = _context.Comenzi.Find(comanda.Id);

            if (toUpdate == null) return;

            _context.Entry(toUpdate).CurrentValues.SetValues(comanda);
            _context.SaveChanges();
        }

        public bool Exists(int id)
        {
            return _context.Comenzi.Any(c => c.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public StareComanda GetStare(int id)
        {
            var comanda = _context.Comenzi.FirstOrDefault(c => c.Id == id);

            if (comanda != null)
            {
                return comanda.StareComanda;
            }

            return StareComanda.InAsteptare;
        }

        public Comanda FindByDataFinalizare(DateTime data)
        {
            return _context.Comenzi.FirstOrDefault(c => c.DataFinalizare.Equals(data));
        }
    }
}