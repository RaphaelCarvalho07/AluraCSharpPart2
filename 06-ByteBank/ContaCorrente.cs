using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        private Cliente _titular;
        private int _agencia;
        private int _numero;
        private double _saldo = 100;

        public Cliente Titular { get; set; } = new Cliente();
        public int Agencia { get; set; }
        public int Numero { get; set; }

        public double Saldo
        {
            get
            {
                return _saldo;
            }

            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public void Depositar( double valor )
        {
            this._saldo += valor;
        }

        public bool Sacar( double valor )
        {
            if (this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            return true;
        }

        public bool Transferir( double valor, ContaCorrente contaDestino )
        {
            if (this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            contaDestino.Depositar( valor );
            return true;
        }
    }
}
