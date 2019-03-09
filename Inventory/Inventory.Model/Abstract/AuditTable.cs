using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Abstract
{
    public class AuditTable : IAuditTable

    {
        public DateTime? CreateDate { get ; set ; }
        public string CreatedBy { get ; set; }
        public DateTime? UpDateDate { get ; set; }
        public string UpdateBy { get; set; }
        [MaxLength(256)]
        public string MetaKeyword { set; get; }
        [MaxLength(256)]
        public string MetaDescription { set; get; }
        public bool Status { set; get; }
      
    }
}
