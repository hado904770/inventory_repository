using Inventory.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Service.Interface
{
    public interface IErorrSerivce
    {
        Error Create(Error error);
        void Save();

    }
}
