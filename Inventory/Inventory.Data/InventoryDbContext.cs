using Inventory.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext() : base("Inventory")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Employee> Employees { set; get; }
        public DbSet<Error> Errors { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
