using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main( string[ ] args )
        {
            ContaCorrente contaDoRapha = new ContaCorrente();
            ContaCorrente contaDaBina = new ContaCorrente();

            contaDoRapha.titular = "Raphael";
            contaDaBina.titular = "Bina";
            Console.WriteLine( $"Saldo atual da {contaDaBina.titular} é {contaDaBina.saldo }" );
            Console.WriteLine( $"Saldo atual da {contaDaBina.titular} é {contaDaBina.saldo }" );
            
            contaDoRapha.Depositar( 500 );
            contaDaBina.Sacar( 50 );
            Console.WriteLine( $"Saldo atual do {contaDoRapha.titular} é {contaDoRapha.saldo }" );
            Console.WriteLine( $"Saldo atual da {contaDaBina.titular} é {contaDaBina.saldo }" );
            
            contaDoRapha.Transferir(150, contaDaBina);
            Console.WriteLine( $"Saldo atual do {contaDoRapha.titular} é {contaDoRapha.saldo }" );
            Console.WriteLine( $"Saldo atual da {contaDaBina.titular} é {contaDaBina.saldo }" );
        }
    }
}
