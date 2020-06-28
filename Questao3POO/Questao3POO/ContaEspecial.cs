using System;
using System.Collections.Generic;
using System.Text;

namespace Questao3POO
{
    public class ContaEspecial : ContaBancaria, IImprimivel
    {
        private double _limite;

        public double Limite
        {
            get { return _limite; }
            set { _limite = value; }
        }

        public override void Depositar(double valor)
        {
            Saldo += valor;
        }

        public string MostrarDados()
        {
            string dados = "Conta Especial: " + NumeroConta;
            dados += " possui Saldo: " + Saldo;

            return dados;
        }

        public override void Sacar(double valor)
        {
            if ((Saldo - valor) < (- _limite))
                throw new Exception("Conta " + NumeroConta + " possui saldo insuficiente para realizar este saque.");

            Saldo -= valor;
        }
    }
}
