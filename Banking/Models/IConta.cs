using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Banking
{
    public interface IConta
    {

        double ChecaSaldo();
        bool Saque(double valor);
        bool Transferencia(String contaDestino, double valor);
        bool Deposito(double valor);
            
    }
}