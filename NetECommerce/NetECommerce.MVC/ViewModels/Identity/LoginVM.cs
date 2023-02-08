using System.ComponentModel.DataAnnotations;

namespace NetECommerce.MVC.ViewModels.Identity
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Email zorunlu!")]
        [EmailAddress(ErrorMessage = "Email adresi yanlış!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre zorunlu")]
        public string Password { get; set; }
    }
}
