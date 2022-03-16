using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main( string[ ] args )
        {
            ContaCorrente conta = new ContaCorrente( 487, 487123 );
            ContaCorrente conta2 = new ContaCorrente( 487, 487321 );

            Console.WriteLine( ContaCorrente.TotalContasCriadas );
        }
    }
}
