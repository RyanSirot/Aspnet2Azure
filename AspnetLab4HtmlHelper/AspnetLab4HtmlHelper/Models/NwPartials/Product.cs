using AspnetLab4HtmlHelper.Models.CustomValidation;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace AspnetLab4HtmlHelper.Models
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product { }

    public class ProductMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public object ProductID { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [Display(Name = "Product Name")]
       // [StringLength(3, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 1)]  
        [WordCount(3, ErrorMessage = "Words between 1-3")]     
        public object ProductName { get; set; }

        [Required(ErrorMessage = "Unit price is required.")]
        [DataType(DataType.Currency)]
        public object UnitPrice { get; set; }

        [ScaffoldColumn(false)]
        public object ReorderLevel { get; set; }

        [UIHint("_CategoryDropDown")]
        [Display(Name = "Category")]
        public object CategoryID { get; set; }

        [ScaffoldColumn(false)]
        public object UnitsInStock { get; set; }

        [Display(Name = "Units On Order")]
        [ScaffoldColumn(false)]
        public object UnitsOnOrder { get; set; }

        [Display(Name = "Quantity Per Unit")]
        [ScaffoldColumn(false)]
        public object QuantityPerUnit { get; set; }

        [ScaffoldColumn(false)]
        public object Discontinued { get; set; }

        [UIHint("_SupplierDropDown")]
        [Display(Name = "Supplier")]
        public object SupplierID { get; set; }

    }


}