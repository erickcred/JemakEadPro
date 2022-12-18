using System.ComponentModel.DataAnnotations;

namespace JemakEadPro.Models.Enums.Curso
{
    public enum ETipoCurso
    {
        [Display(Name = "Assinatura IED")]
        AssinaturaIed = 1,
        Capacitacao = 2,
        AoVivo = 3,
        CurtaDuracao = 4

    }
}