using Inventory.Data.Repository.Interface;
using Inventory.Model.Models;
using OnlineShop.Data.Infratructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Repository
{
    public class ErorrRepository : RepositoryBase<Error>, IErorrRepository
    {
        public ErorrRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
