using System;
using System.Collections.Generic;

namespace JemakEadPro.Models
{
    public class Usuario
    {
        public Usuario()
        {
            Senha = CPF;
            Ativo = true;
            DataCadastro = DateTime.Now;
            Andamentos = new List<Andamento>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string TelefoneTrabalho { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CarteiraProfissional { get; set; } // CRM, CRC, OAB etc..
        public string Senha { get; set; }
        public string Perfil { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Imagem { get; set; }
        public bool? Ativo { get; set; }

        public string CEP { get; set; }
        public string Endereco { get; set; } // Nome da Rua
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }

        public string NomeResponsavel { get; set; }
        public string CpfCnpj { get; set; }
        public string ResponsavelTelefone { get; set; }

        public List<Contrato> Contratos { get; set; }

        // virtual
        public List<Andamento> Andamentos { get; set; }
        


    }
}