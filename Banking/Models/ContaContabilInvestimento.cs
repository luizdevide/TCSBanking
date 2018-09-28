using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Banking
{
    public class ContaContabilInvestimento : IConta
    {
        [Key]
        public int Id { get; set; }
        public Banco Banco
        {
            get => default(Banco);
            set
            {
            }
        }

        public double Saldo
        {
            get => default(int);
            set
            {
            }
        }

        public bool Deposito(double valor)
        {
            throw new NotImplementedException();
        }

        public double ChecaSaldo()
        {
            throw new NotImplementedException();
        }

        public bool Saque(double valor)
        {
            throw new NotImplementedException();
        }

        public bool Transferencia(string contaDestino, double valor)
        {
            throw new NotImplementedException();
        }
    }
}