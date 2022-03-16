using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    internal class Program
    {
        static void Main( string[ ] args )
        {
            ContaCorrente conta = new ContaCorrente();
            //conta.Titular = new Cliente();

            conta.Titular.Nome = "Bina Carvalho";
            conta.Titular.CPF = "458.147.852.19";
            conta.Titular.Profissao = "Advogada";
            conta.Agencia = 852;
            conta.Numero = 852121;
            conta.Saldo = 1200.50;

            Console.WriteLine( $"Titular da conta: {conta.Titular.Nome}" );
            Console.WriteLine( $"Profissão titular da conta: {conta.Titular.Profissao}" );
            Console.WriteLine( $"Saldo da conta R${conta.Saldo}" );

            conta.Depositar( 1000 );
            Console.WriteLine( $"Saldo da conta atual R${conta.Saldo}" );
            conta.Sacar( 150 );
            Console.WriteLine( $"Saldo da conta atual R${conta.Saldo}" );
        }
    }
}
