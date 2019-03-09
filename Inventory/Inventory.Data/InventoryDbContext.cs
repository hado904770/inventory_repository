using Inventory.Model.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data
{
    public class InventoryDbContext : IdentityDbContext<ApplicationUser>
    {
        public InventoryDbContext() : base("Inventory")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Employee> Employees { set; get; }
        public DbSet<Error> Errors { set; get; }

        public static InventoryDbContext Create()
        {
            return new InventoryDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
