using System.ComponentModel.DataAnnotations;

namespace NetECommerce.MVC.Areas.Dashboard.ViewModels
{
    public class SupplierVM
    {
        [Required(ErrorMessage ="Şirket adı boş geçilemez!")]
        public string CompanyName { get; set; }

        public string ContactTitle { get; set; }

        [Required(ErrorMessage = "Telefon no. boş geçilemez!")]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "Adres boş geçilemez!")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Şehir boş geçilemez!")]
        public string City { get; set; }

        [Required(ErrorMessage = "Bölge boş geçilemez!")]
        public string Region { get; set; }

        [Required(ErrorMessage = "Posta kodu boş geçilemez!")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Ülke boş geçilemez!")]
        public string Country { get; set; }
    }
}
