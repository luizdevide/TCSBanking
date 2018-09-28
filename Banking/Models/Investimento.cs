using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using Banking.Controllers;
using Banking.Models;
using System.Data.Entity;

namespace Banking
{
    public class Investimento
    {
        private BankingContext db = new BankingContext();
        public ContaContabilInvestimento ContaContabilInvestimento
        {
            get => default(ContaContabilInvestimento);
            set
            {
            }
        }

        public string tipoTaxa
        {
            get => default(string);
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

        public DateTime dataEntrada
        {
            get => default(DateTime);
            set
            {
            }
        }

        public DateTime dataResgate
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

        public bool ValidaSolicitacao(double quantia, string tipo, DateTime data)
        {
            ContaCorrente cc = new ContaCorrente();
            ContaContabilInvestimento cci = new ContaContabilInvestimento();
            ContaContabilInvestimentoesController ccic = new ContaContabilInvestimentoesController();
            if (cc.Saldo + cc.limite > quantia)
            {
                cc.Saldo -= quantia;
                db.Entry(cc).State = EntityState.Modified;
                db.SaveChanges();
                
                cci.Saldo += quantia;
                db.Entry(cci).State = EntityState.Modified;
                db.SaveChanges();

                dataEntrada = DateTime.Now;
                tipoTaxa = tipo;
                valor = quantia;
                dataResgate = data;

                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
            }
            return true;
            dataEntrada = DateTime.Now.Date;
            throw new System.NotImplementedException();
        }

        public double Resgate()
        {
            ContaCorrente cc = new ContaCorrente();
            ContaContabilInvestimento cci = new ContaContabilInvestimento();
            DateTime data = DateTime.Now;
            int tempo;
            if (tipoTaxa == "Selic")
            {                                
                tempo =  Convert.ToInt32((data - dataEntrada).TotalDays / 30);
                for (int i = 0; i < tempo; i++)
                {
                    valor += (valor * (0.065));
                }                
                cci.Saldo -= valor;
                db.Entry(cci).State = EntityState.Modified;
                db.SaveChanges();
                return valor;
            }
            else if (tipoTaxa == "IPCA")
            {
                tempo = Convert.ToInt32((data - dataEntrada).TotalDays / 30);
                for (int i = 0; i < tempo; i++)
                {
                    valor += (valor * (0.065));
                }
                cci.Saldo -= valor;
                db.Entry(cci).State = EntityState.Modified;
                db.SaveChanges();
                return valor;
            }
            throw new System.NotImplementedException();
        }
    }
}