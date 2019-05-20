using System;
using System.Data.Entity;
using System.Linq;
using Studies.api;
using Studies.models;

namespace Studies
{
    public class InterfaceCaseTesting
    {
        public static EntityState ConvertState(State state)
        {
            switch (state)
            {
                case State.Added:
                    return EntityState.Added;
                case State.Modified:
                    return EntityState.Modified;
                case State.Deleted:
                    return EntityState.Deleted;
                default:
                    return EntityState.Unchanged;
            }
        }

        public static void SaveCustomerTypeGraph(CustomerType customerType)
        {
            using (var context = new Model1ContainerContainer())
            {
                context.CustomerTypes.Add(customerType);
                foreach (var entry in context.ChangeTracker
                    .Entries<IObjectWithState>())
                {
                    IObjectWithState stateInfo = entry.Entity;
                    entry.State = ConvertState(stateInfo.State);
                }

                context.SaveChanges();
            }
        }

        public static void TestSaveCustomerTypeGraph()
        {
            CustomerType ct;
            using (var context = new Model1ContainerContainer())
            {
                ct = (from d in context.CustomerTypes.Include(d => d.Customers)
                      where d.Description == "Preferat"
                      select d).Single();
            } // context distrus

            ct.Description = "Super preferat";
            ct.State = State.Modified;
            var firstCustomer = ct.Customers.First();
            firstCustomer.Name = "Alfa Omega srl";
            firstCustomer.State = State.Modified;
            var secondCustomer = ct.Customers.Last();
            secondCustomer.State = State.Deleted;
            ct.Customers.Add(new Customer
            {
                Name = "EON srl",
                State = State.Added
            });
            SaveCustomerTypeGraph(ct);
        }

        public static void CheckForEntitiesWithoutStateInterface(
            Model1ContainerContainer context)
        {
            var entitiesWithoutState = from e in context.ChangeTracker.Entries()
                                       where !(e.Entity is IObjectWithState)
                                       select e;
            if (entitiesWithoutState.Any())
            {
                throw new NotSupportedException(
                    "Toate entitatile trebuie sa implementeze IObjectWithState");
            }
        }

        private static void ApplyChanges<TEntity>(TEntity root)
            where TEntity : class, IObjectWithState
        {
            using (var context = new Model1ContainerContainer())
            {
                context.Set<TEntity>().Add(root);
                // cazul cand o clasa din model nu implementeaza
                // interfata IObjectWithState
                CheckForEntitiesWithoutStateInterface(context);
                foreach (var entry in context.ChangeTracker
                    .Entries<IObjectWithState>())
                {
                    IObjectWithState stateInfo = entry.Entity;
                    entry.State = ConvertState(stateInfo.State);
                }

                context.SaveChanges();
            }
        }
    }
}
