using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFormsApp.Models
{
    public class Product
   {
        [Display(Name="Ürün Id")]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Ürün adı zorunludur")]
        [StringLength(100)]
        [Display(Name="Ürün Adı")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Fiyat zorunludur")]
        [Range(0,100)]
        [Display(Name="Ürün Fiyatı")]
        public double Price { get; set; }
        [Display(Name="Ürün Resmi")]
        [Required(ErrorMessage = "Fotoğraf zorunludur")]
        public string Image { get; set; }
        [Display(Name="Aktif Mi?")]
        public bool IsActive { get; set; }
        [Display(Name="Kategori")]
        public int CategoryId { get; set; }
    }
}