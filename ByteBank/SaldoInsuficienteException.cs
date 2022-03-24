using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteException : Exception // creation of my exception
    {
        public SaldoInsuficienteException()
        {
        }

        public double Saldo { get; }
        public double ValorSaque { get; set; }

        public SaldoInsuficienteException(string mensagem) : base(mensagem) // we need the base because is where the messege propertie comes from. As a propertie is part of the argument class
        {

        }
        public SaldoInsuficienteException(double saldo, double valorsaque) : this ("Tentativa de saque no valor de " + valorsaque + " em uma conta com saldo de " + saldo)
                                                                           // this is a reference to the constructor above where we call the base messege.
        {
            Saldo = saldo;
            ValorSaque = valorsaque;
        }

       
    }
}
