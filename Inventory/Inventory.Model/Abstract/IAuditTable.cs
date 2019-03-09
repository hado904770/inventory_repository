using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Model.Abstract
{
    public interface IAuditTable
    {
        DateTime? CreateDate { set; get; }

        [MaxLength(256)]
        string CreatedBy { set; get; }

        bool Status { set; get; }

        DateTime? UpDateDate { set; get; }

        [MaxLength(256)]
        string UpdateBy { set; get; }

        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }
    }
}