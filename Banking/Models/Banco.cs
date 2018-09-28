using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Banking
{
    public class Banco
    {
        [Key]
        public int Cnpj { get; set; }
        public string Nome { get; set; }

        public Banco()
        {

        }
        public Banco(int cnpj, string nome)
        {
            Cnpj = cnpj;
            Nome = nome;
        }
    }
}