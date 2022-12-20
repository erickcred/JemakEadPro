using System;
using System.ComponentModel.DataAnnotations;
using JemakEadPro.Data;
using JemakEadPro.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authorization;

namespace JemakEadPro.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "E-mail deve ser preenchido!")]
        [EmailAddress(ErrorMessage = "Usuário ou senha Invalidos!")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Senha deve ser preenchido!")]
        [EmailAddress(ErrorMessage = "Usuário ou senha Invalidos!")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        
    }
}