using System;
using System.Collections.Generic;
using System.Text;

namespace Questao3POO
{
    abstract public class ContaBancaria
    {
        private int _numeroConta;
        private double _saldo;

        public int NumeroConta
        {
            get { return _numeroConta; }
            set { _numeroConta = value; }
        }

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public abstract void Sacar(double valor);

        public abstract void Depositar(double valor);
    }
}
