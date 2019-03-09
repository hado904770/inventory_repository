using OnlineShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model.Models
{
    public class Error : TrackingChanges
    {
        public int Id { set; get; }
        public string Message  { get; set; }

        public string StackTrace { set; get; }
        
    }
}
