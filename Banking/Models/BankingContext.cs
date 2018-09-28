using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Banking.Models
{
    public class BankingContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BankingContext() : base("name=BankingContext")
        {
        }

        public System.Data.Entity.DbSet<Banking.Banco> Bancoes { get; set; }

        public System.Data.Entity.DbSet<Banking.ContaContabilEmprestimo> ContaContabilEmprestimoes { get; set; }

        public System.Data.Entity.DbSet<Banking.ContaContabilInvestimento> ContaContabilInvestimentoes { get; set; }

        public System.Data.Entity.DbSet<Banking.ContaCorrente> ContaCorrentes { get; set; }

        public System.Data.Entity.DbSet<Banking.Emprestimo> Emprestimoes { get; set; }

        public System.Data.Entity.DbSet<Banking.Investimento> Investimentoes { get; set; }

        public System.Data.Entity.DbSet<Banking.Movimentacao> Movimentacaos { get; set; }

        public System.Data.Entity.DbSet<Banking.Pessoa> Pessoas { get; set; }
    }
}
