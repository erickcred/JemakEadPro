using System.ComponentModel.DataAnnotations;

namespace JemakEadPro.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "E-mail deve ser preenchido")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Senha deve ser preenchido")]
        public string Senha { get; set; }
    }
}