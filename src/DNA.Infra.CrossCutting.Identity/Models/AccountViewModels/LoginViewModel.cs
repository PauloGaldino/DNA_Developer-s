using System.ComponentModel.DataAnnotations;

namespace DNA.CrossCutting.Identity.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail ")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Display(Name = "Lembrar desta conta? ")]
        public bool RememberMe { get; set; }
    }
}
