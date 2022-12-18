using System;
using System.Collections.Generic;

namespace JemakEadPro.Models
{
    public class Contrato
    {
        public Contrato()
        {
            DataMatricula = DateTime.Now;
        }
        
        public int Id { get; set; }
        public Usuario Aluno { get; set; }
        public List<Curso> Cursos { get; set; }

        public DateTime DataMatricula { get; set; }
        public DateTime DataEncerramento { get; set; }
        
    }
}