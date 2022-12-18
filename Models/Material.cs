using System;

namespace JemakEadPro.Models
{
    public class Material
    {
        public Material()
        {
            DataCriacao = DateTime.Now;
        }
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Url { get; set; }
        public Curso Curso { get; set; }
        

        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}