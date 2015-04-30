using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ViewModels
{
    public class ProdVM
    {
        public virtual int Id { get; set; }
        public virtual string EAN { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual int BrandId { get; set; }
        [Display(Name = "Product Name")]
        public virtual string Name { get; set; }
        [Display(Name = "Product Description")]
        public virtual string Description { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name = "Product Price")]
        public virtual double Price { get; set; }
        [Display(Name = "In Stock")]
        public virtual int StockLevel { get; set; }
        public virtual bool Active { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public int VendorID { get; set; }
        //public virtual Category Category { get; set; }
        //public virtual Brand Brand { get; set; }
    }
}