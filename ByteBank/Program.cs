using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(456, 45857);
                ContaCorrente conta2 = new ContaCorrente(524, 25417);

                conta2.Transferir(-10, conta); // -10 causes an argument exception

                conta.Depositar(5);
                Console.WriteLine(conta.Saldo); 
                conta.Sacar(-500); // -500 causes an argument exception


            }
            catch (ArgumentException ex)
            {
                if(ex.ParamName == "numero")
                {

                }

                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);


            try
            {
                Metodo();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }





            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }

        // Teste com a cadeia de chamada:
        // Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            if (divisor <= 0)
            {
                throw new DivideByZeroException("Tentativa de divisão por 0 com o numero " + numero + " e divisor " + divisor);
            }
            return numero / divisor;

        }

    }
}
