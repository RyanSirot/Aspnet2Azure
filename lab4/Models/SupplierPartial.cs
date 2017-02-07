using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace lab4.Models
{
    [MetadataType(typeof(SupplierMetaData))]
    public partial class Supplier
    {
    }

    public class SupplierMetaData
    {

        [Display(Name = "Supplier")]
        public Object CompanyName { get; set; }


    }
}