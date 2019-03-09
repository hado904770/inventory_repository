using OnlineShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inventory.Model.Models
{
    public class Employee : TrackingChanges
    {
       
        public int Id { set; get; }
        [MaxLength(256)]
        public string FullName { set; get; }
        [MaxLength(256)]
        public string NickName { set; get; }
        [MaxLength(256)]
        public string Address { set; get; }
        public DateTime BirthDay { set; get; }

    }
}
