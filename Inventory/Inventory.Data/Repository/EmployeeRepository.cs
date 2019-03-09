using Inventory.Model.Models;
using OnlineShop.Data.Infratructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Repository.Interface
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<Employee> GetNickName(string nickname)
        {
            return this.DbContext.Employees.Where(x => x.NickName.Equals(nickname));
        }
    }
}
