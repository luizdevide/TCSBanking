using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Banking
{
    public class Emprestimo
    {

        public ContaContabilEmprestimo ContaContabilEmprestimo
        {
            get => default(ContaContabilEmprestimo);
            set
            {
            }
        }

        public DateTime dataPagamento
        {
            get => default(DateTime);
            set
            {
            }
        }

        public DateTime dataEmprestimo
        {
            get => default(DateTime);
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

        public int numeroParcelas
        {
            get => default(int);
            set
            {
            }
        }

        public string formaPagamento
        {
            get => default(string);
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

        [Key]
        public int Id
        {
            get => default(int);
            set
            {
            }
        }

        public Boolean ValidaSolicitacao(float valor, float limite)
        {
            ContaCorrente contaC = new ContaCorrente();
            Pessoa pessoa = new Pessoa();
            ContaContabilEmprestimo contaContabilEmprestimo = new ContaContabilEmprestimo();
            
            if (contaC.limite >= 1000)
            {        
                dataEmprestimo = DateTime.Now;
                this.CalcularParcela(numeroParcelas);
     
                return true;
            }
            else
            {
                return false;
            }
        }

        public Double CalcularParcela(int numeroParcelas)
        {
            ContaCorrente contaC = new ContaCorrente();
            ContaContabilEmprestimo contaCE = new ContaContabilEmprestimo();
            double valorTaxa = this.CalcularTaxa(tipoTaxa);

            double valorTotal = valor * valorTaxa;
            double valorParcela = (valorTotal / numeroParcelas) * valorTaxa;

            if (formaPagamento.Equals("Debito"))
            {
                for (int i = 1; i <= numeroParcelas; i++)
                {
                    if (valorParcela >= contaC.Saldo)
                    {
                        valorParcela = valorParcela * valorTaxa;  
                    }
                    dataPagamento = dataEmprestimo.AddMonths(i);
                    contaC.Saldo -= valorParcela;
                    contaCE.Saldo += valorParcela;
                }
            }
            else if (formaPagamento.Equals("Boleto"))
            {
                for (int i = 1; i <= numeroParcelas; i++)
                {
                    dataPagamento = dataEmprestimo.AddMonths(i);
                    contaC.Saldo -= valorParcela;
                    contaCE.Saldo += valorParcela;
                }    
            }
            return valorParcela;
        }

        public double CalcularTaxa(String tipoTaxa)
        {
            double valorTaxa = 0;

            if (tipoTaxa.Equals("Pessoal"))
            {
                valorTaxa = valorTaxa * 1.0582;
            }
            else if (tipoTaxa.Equals("Consignado"))
            {
                valorTaxa = valorTaxa * 1.3;
            }
         
            return valorTaxa;
        }
    }
}