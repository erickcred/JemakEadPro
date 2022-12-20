using System.ComponentModel.DataAnnotations;

namespace JemakEadPro.Models.Enums.Curso
{
    public enum ETipoCurso
    {
        [Display(Name = "Assinatura IED")]
        AssinaturaIed = 1,

        [Display(Name = "Capacitação")]
        Capacitacao = 2,

        [Display(Name = "Ao Vivo")]
        AoVivo = 3,
        
        [Display(Name = "Curta Duração")]
        CurtaDuracao = 4

    }
}