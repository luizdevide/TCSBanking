using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using Banking.Models;
using System.Data.Entity;

namespace Banking
{
    public class Movimentacao
    {
        private BankingContext db = new BankingContext();
        public string numeroCC
        {
            get => default(string);
            set
            {
            }
        }

        public String descricao
        {
            get => default(String);
            set
            {
            }
        }

        public double valor
        {
            get => default(double);
            set
            {
            }
        }

        public string numeroDestino
        {
            get => default(string);
            set
            {
            }
        }

        public DateTime data
        {
            get => default(DateTime);
            set
            {
            }
        }

        public int Id
        {
            get => default(int);
            set
            {
            }
        }

        public override string ToString()
        {
            db.Entry(this).State = EntityState.Modified;
            db.SaveChanges();

            return "Conta: "+ numeroCC+
                    "Tipo de movimentação: "+ descricao+
                    "Valor: "+ valor+
                    "Conta destino: " +numeroDestino+
                    "Data da movimentação: "+ data ;
        }
    }
}