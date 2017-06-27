using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCShoppingData
{
    
    public class MVCProductMetadata
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage ="*Required")]
        [StringLength(250, ErrorMessage ="*Enter no more than 250 characters please")]
        [Display(Name ="Product")]
        public string ProductName { get; set; }
        [UIHint("MultilineText")]
        [Display(Name = "Description")]
        public string ProdDescription { get; set; }
        [Required(ErrorMessage = "*Required")]
        [DisplayFormat(DataFormatString ="{0:c}",ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }
        [StringLength(25, ErrorMessage = "*Enter no more than 25 characters please")]
        public string ModelNumber { get; set; }
        [StringLength(100, ErrorMessage = "*Please assure that the length of the image name is less than 100 characters")]
        public string Image { get; set; }
        //[Required(ErrorMessage = "*Required")] --autopopulated--
        public System.DateTime LastUpdated { get; set; }
        public Nullable<int> CategoryID { get; set; }
        [Required(ErrorMessage = "*Required")]
        public int StatusID { get; set; }
        [Required(ErrorMessage = "*Required")]
        public int VendorID { get; set; }
    }
    [MetadataType(typeof(MVCProductMetadata))]
    public partial class MVCProduct { }

    public class MVCCategoryMetadata
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "*Required")]
        [StringLength(100, ErrorMessage = "*Enter no more than 100 characters please")]
        [Display(Name = "Category")]
        public string CategoryName { get; set; }
        [UIHint("MultilineText")]
        [StringLength(500, ErrorMessage = "*Enter no more than 500 characters please")]
        [Display(Name ="Description")]
        public string CategoryDescription { get; set; }
        [Required(ErrorMessage = "*Required")]
        public bool IsActive { get; set; }
    }
    [MetadataType(typeof(MVCCategoryMetadata))]
    public partial class MVCCategory { }

    public class MVCStatusMetadata
    {
        public int StatusID { get; set; }
        [Required(ErrorMessage = "*Required")]
        [StringLength(50, ErrorMessage = "*Enter no more than 50 characters please")]
        [Display(Name = "Status Name")]
        public string StatusName { get; set; }
        [UIHint("MultilineText")]
        [StringLength(250, ErrorMessage = "*Enter no more than 250 characters please")]
        [Display(Name = "Description")]
        public string StatusDescription { get; set; }
    }
    [MetadataType(typeof(MVCStatusMetadata))]
    public partial class MVCStatus { }

    public class MVCVendorMetadata
    {
        public int VendorID { get; set; }
        [Required(ErrorMessage = "*Required")]
        [StringLength(100, ErrorMessage = "*Enter no more than 100 characters please")]
        [Display(Name = "Vendor")]
        public string VendorName { get; set; }
        
        [StringLength(100, ErrorMessage = "*Please assure that the length of the image name is less than 100 characters")]
        public string Image { get; set; }
        [StringLength(400, ErrorMessage = "*Enter no more than 400 characters please")]
        public string WebsiteURL { get; set; }
        [Required(ErrorMessage = "*Required")]
        public bool IsActive { get; set; }
    }
}
