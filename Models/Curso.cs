using System;
using System.Collections.Generic;
using JemakEadPro.Models.Enums.Curso;

namespace JemakEadPro.Models
{
    public class Curso
    {
        public Curso()
        {
            Ativo = true;
            DataCriacao = DateTime.Now;
        }

        public string ProjetoToken { get; set; }
        public int ProjetoId { get; set; } // 10984,
        public string ProjetoPlayerKey { get; set; }


        public int Id { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public string Situacao { get; set; }
        public string Categoria { get; set; } // Mostra a categoria (Contabil, Fiscal etc..)
        public int CargaHoraria { get; set; } // Carga horária Total para apresentação externa 
        public ETipoCurso TipoCurso { get; set; }
        public bool? Ativo { get; set; }
        public Contrato Contrato { get; set; }

        public string Descricao { get; set; }
        public string Objetivo { get; set; }
        public string ParaQuem { get; set; }
        public string EstruturaDoCurso { get; set; }
        public string AcessoIlimitado { get; set; }
        public string Metodologia { get; set; }
        public string Excelencia { get; set; }
        public string Atencao { get; set; }

        public string Professor { get; set; }

        public DateTime DataSubmicaoCRC { get; set; }
        public DateTime DataVencimentoCRC { get; set; }
        public string TurmaCRC { get; set; }
        public string CodigoCursoCRC { get; set; }
        public string CategoriasPontuacao { get; set; }
        public int Pontos { get; set; }

        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }


        public List<Andamento> Andamentos { get; set; }
        public List<Material> Materiais { get; set; }
        public List<Video> Videos { get; set; }
        

    }
}