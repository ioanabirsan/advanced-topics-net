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

        public void Update(int id, Auto auto)
        {
            if(auto == null) return;
     
            if(!Exists(id)) return;

            var toUpdate = _context.Automobile.First(a => a.Id == id);
            toUpdate.NumarAuto = auto.NumarAuto;
            toUpdate.SerieSasiu = auto.SerieSasiu;

            _context.SaveChanges();
        }

        public bool Exists(int id)
        {
            return _context.Automobile.Any(auto => auto.Id == id);
        }

        public void SaveChanges()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
    }
}
