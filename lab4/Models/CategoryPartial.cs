using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace lab4.Models
{
    [MetadataType(typeof(CategoryMetaData))]
    public partial class Category
    {
    }

    public class CategoryMetaData
    {

  
        [Display(Name = "Category")]
        public Object CategoryName { get; set; }


    }
}