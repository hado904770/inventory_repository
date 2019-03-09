using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Abstract
{
    public interface ITrackingChanges
    {
        DateTime? CreatedDate { set; get; }

        [MaxLength(256)]
        string CreatedBy { set; get; }

        DateTime? LastUpdateBy { set; get; }

        [MaxLength(256)]
        string LastUpdateDate { set; get; }

    }
}
