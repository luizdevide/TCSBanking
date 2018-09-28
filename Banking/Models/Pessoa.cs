using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Banking.Models;
using System.Data.Entity;

namespace Banking
{
    
    public class Pessoa
    {
        private BankingContext db = new BankingContext();
        public String Nome { get; set; }
        [Key]
        public String CPF { get; set; }
        public String RG { get; set; }



        public override string ToString()
        {
            db.Entry(this).State = EntityState.Modified;
            db.SaveChanges();
            return "Nome: "+Nome+
                    "CPF"+CPF+
                    "RG"+RG;
        }
    }
}