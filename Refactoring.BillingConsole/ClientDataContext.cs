using Refactoring.DataContracts;
using Refactoring.Transactions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.BillingConsole
{
   public class ClientDataContext : DbContext
   {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
    }

   public class ClientDataContextAdapter : IDbSetFactory, IDbContext
    {
        private readonly DbContext _context;

        public ClientDataContextAdapter(DbContext context)
        {
            _context = context;
        }

        #region IObjectContext Members

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        #endregion

        #region IObjectSetFactory Members

        public void Dispose()
        {
            _context.Dispose();
        }

        public DbSet<T> CreateDbSet<T>() where T : class
        {
            return _context.Set<T>();
        }

        public void ChangeObjectState(object entity, EntityState state)
        {
            _context.Entry(entity).State = state;
        }

        public void RefreshEntity<T>(ref T entity) where T : class
        {
            _context.Entry<T>(entity).Reload();
        }

        #endregion
    }
}
