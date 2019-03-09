using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Infratructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
