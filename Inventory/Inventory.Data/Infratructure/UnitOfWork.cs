using Inventory.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Infratructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private InventoryDbContext dbContext;


        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public void Commit()
        {
            DbContext.SaveChanges();
        }
        public InventoryDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }
    }
}
