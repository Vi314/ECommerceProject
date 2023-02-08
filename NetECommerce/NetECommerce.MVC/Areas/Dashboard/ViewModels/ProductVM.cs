using NetECommerce.Entity.Entity;
using System.ComponentModel.DataAnnotations;

namespace NetECommerce.MVC.Areas.Dashboard.ViewModels
{
    public class ProductVM
    {

        [Required(ErrorMessage = "Ürün adı boş geçilemez!")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Birim fiyatı boş geçilemez!")]
        public decimal? UnitPrice { get; set; }
        [Required(ErrorMessage = "Stok miktarı boş geçilemez!")]
        public short? UnitsInStock { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        [Required(ErrorMessage = "Kategori boş geçilemez!")]
        public int? CategoryId { get; set; }
        [Required(ErrorMessage = "Tedarikçi boş geçilemez!")]
        public int? SupplierId { get; set; }
    }
}
