using System;
using System.Collections.Generic;
using System.Linq;
using CarService.Repository.api;

namespace CarService.Repository.impl
{
    public class DetaliuComandaRepository : IRepository<DetaliuComanda>
    {
        private readonly CarServiceModelContainer _context;

        public DetaliuComandaRepository(CarServiceModelContainer context)
        {
            _context = context;
        }

        public DetaliuComanda GetById(int id)
        {
            return _context.DetaliiComenzi.FirstOrDefault(d => d.Id == id);
        }

        public IReadOnlyList<DetaliuComanda> GetAll()
        {
            return _context.DetaliiComenzi.ToList();
        }

        public void Create(DetaliuComanda detaliuComanda)
        {
            _context.DetaliiComenzi.Add(detaliuComanda);
        }

        public void Delete(int id)
        {
            if(!Exists(id)) return;

            var detaliuComanda = _context.DetaliiComenzi.First(d => d.Id == id);
            _context.DetaliiComenzi.Remove(detaliuComanda);
            _context.SaveChanges();
        }

        public void Update(DetaliuComanda detaliuComanda)
        {
            var toUpdate = _context.DetaliiComenzi.Find(detaliuComanda.Id);

            if (toUpdate == null) return;

            _context.Entry(toUpdate).CurrentValues.SetValues(detaliuComanda);
            _context.SaveChanges();
        }

        public bool Exists(int id)
        {
            return _context.DetaliiComenzi.Any(d => d.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public DetaliuComanda FindByComanda(int comandaId)
        {
            return _context.DetaliiComenzi.FirstOrDefault(d => d.Comanda.Id == comandaId);
        }

        public IReadOnlyList<Mecanic> GetMecanici(int comandaId)
        {
            var detaliuComanda = _context.DetaliiComenzi.FirstOrDefault(d => d.Comanda.Id == comandaId);

            return detaliuComanda?.Mecanici.ToList();
        }

        public IReadOnlyList<Operatie> GetOperatii(int comandaId)
        {
            var detaliuComanda = _context.DetaliiComenzi.FirstOrDefault(d => d.Comanda.Id == comandaId);

            return detaliuComanda?.Operatii.ToList();
        }

        public IReadOnlyList<Imagine> GetImagini(int comandaId)
        {
            var detaliuComanda = _context.DetaliiComenzi.FirstOrDefault(d => d.Comanda.Id == comandaId);

            return detaliuComanda?.Imagini.ToList();
        }

        public IReadOnlyList<Material> GetMateriale(int comandaId)
        {
            var detaliuComanda = _context.DetaliiComenzi.FirstOrDefault(d => d.Comanda.Id == comandaId);

            return detaliuComanda?.Materiale.ToList();
        }
    }
}
