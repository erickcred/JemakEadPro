using System;

namespace JemakEadPro.Models
{
    public class Andamento
    {
        public Andamento()
        {
            DataInicio = DateTime.Now;
        }

        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Curso Curso { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}