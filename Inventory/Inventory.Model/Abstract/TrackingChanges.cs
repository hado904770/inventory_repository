using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Abstract
{
    public class TrackingChanges : ITrackingChanges
    {
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastUpdateBy { get; set; }
        public string LastUpdateDate { get; set; }
    }
}
