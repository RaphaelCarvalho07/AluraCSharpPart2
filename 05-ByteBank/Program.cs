using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    internal class Program
    {
        static void Main( string[ ] args )
        {
            ContaCorrente contaDaBina = new ContaCorrente();
            contaDaBina.titular = new Cliente();

            contaDaBina.titular.name = "Bina Carvalho";
            contaDaBina.titular.cpf = "485.587.936.17";
            contaDaBina.titular.profissao = "Advogata";
            contaDaBina.agencia = 487;
            contaDaBina.numero = 487121;
            contaDaBina.Depositar( 1000 );

            Console.WriteLine( "==============Lista de Clientes VIP===================" );
            Console.WriteLine( $"Titular: {contaDaBina.titular.name}" );
            Console.WriteLine( $"CPF: {contaDaBina.titular.cpf}" );
            Console.WriteLine( $"Profissão: {contaDaBina.titular.profissao}" );
            Console.WriteLine( $"Agência: {contaDaBina.agencia}" );
            Console.WriteLine( $"Número: {contaDaBina.numero}" );
            Console.WriteLine( $"Saldo: {contaDaBina.saldo}" );
        }
    }
}
