using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Banking
{
    public class ContaCorrente : IConta
    {
        public string numeroAgencia
        {
            get => default(string);
            set
            {
            }
        }
        public Pessoa titular
        {
            get => default(Pessoa);
            set
            {
            }
        }

        public string numeroConta
        {
            get => default(string);
            set
            {
            }
        }

        public double Saldo
        {
            get => default(Double);
            set
            {
            }
        }

        public string senha
        {
            get => default(string);
            set
            {
            }
        }

        public Double limite
        {
            get => default(Double);
            set
            {
            }
        }

        public List<Movimentacao> movimentacao
        {
            get => default(List<Movimentacao>);
            set
            {
            }
        }

        [Key]
        public int Id
        {
            get => default(int);
            set
            {
            }
        }

        public Emprestimo Emprestimo
        {
            get => default(Emprestimo);
            set
            {
            }
        }

        public Investimento investimento
        {
            get => default(Investimento);
            set
            {
            }
        }

        public bool Deposito(double valor)
        {
            throw new NotImplementedException();
        }

        public Movimentacao Extrato()
        {
            throw new System.NotImplementedException();
        }

        public bool Saque(double valor)
        {
            throw new NotImplementedException();
        }

        public bool Transferencia(string contaDestino, double valor)
        {
            throw new NotImplementedException();
        }

        public bool SolicitaEmprestimo(string formaPagamento, double valor)
        {
            throw new System.NotImplementedException();
        }

        public bool Investimento(string tipo, double valor)
        {
            throw new System.NotImplementedException();
        }

        public bool PagaEmprestimo()
        {
            throw new System.NotImplementedException();
        }

        public List<Movimentacao> FiltrarMovimentacao()
        {
            throw new System.NotImplementedException();
        }

        public bool ResgateInvestimento()
        {
            throw new System.NotImplementedException();
        }

        public void AutenticaLogin()
        {
            throw new System.NotImplementedException();
        }

        public double ChecaSaldo()
        {
            throw new NotImplementedException();
        }
    }
}