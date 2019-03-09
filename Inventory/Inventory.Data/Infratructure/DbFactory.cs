using Inventory.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Infratructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private InventoryDbContext dbContext;
        public InventoryDbContext Init()
        {
            return dbContext ?? (dbContext = new InventoryDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
    
}
