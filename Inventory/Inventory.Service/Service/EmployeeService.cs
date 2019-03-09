using Inventory.Data.Repository.Interface;
using Inventory.Service.Interface;
using OnlineShop.Data.Infratructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Service.Service
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeRepository _employeeRepository;
        IUnitOfWork _unitOfWork;
        public EmployeeService(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork)
        {
            this._employeeRepository = employeeRepository;
            this._unitOfWork = unitOfWork;
        }

    }
}
