using Inventory.Data.Repository.Interface;
using Inventory.Model.Models;
using Inventory.Service.Interface;
using OnlineShop.Data.Infratructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Service.Service
{
    public class ErorrService : IErorrSerivce
    {
        IErorrRepository _erorrRepository;
        IUnitOfWork _unitOfWork;
        public ErorrService(IErorrRepository erorrRepository, IUnitOfWork unitOfWork)
        {
            this._erorrRepository = erorrRepository;
            this._unitOfWork = unitOfWork;
        }

        public Error Create(Error error)
        {
            return _erorrRepository.Add(error);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
