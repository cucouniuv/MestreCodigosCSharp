using System;
using System.Collections.Generic;
using System.Text;

namespace Questao3POO
{
    class ContaCorrente : ContaBancaria, IImprimivel
    {
        private double _taxaOperacao;

        public double TaxaOperacao
        {
            get { return _taxaOperacao; }
            set { _taxaOperacao = value; }
        }

        public override void Depositar(double valor)
        {
            Saldo += valor - _taxaOperacao;
            //throw new NotImplementedException();
        }

        public string MostrarDados()
        {
            string dados = "Conta Corrente: " + NumeroConta;
            dados += " possui Saldo: " + Saldo;

            return dados;
        }

        public override void Sacar(double valor)
        {
            Saldo -= valor - _taxaOperacao;
            //throw new NotImplementedException();
        }
    }
}
