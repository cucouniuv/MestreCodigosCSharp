using System;

namespace Questao3POO
{
    public class ContaCorrente : ContaBancaria, IImprimivel
    {
        public double TaxaOperacao { get; set; }

        public override void Depositar(double valor)
        {
            Saldo += valor - TaxaOperacao;
        }

        public string MostrarDados()
        {
            string dados = "Conta Corrente " + NumeroConta;
            dados += " possui Saldo: " + Saldo.ToString("N2");

            return dados;
        }

        public override void Sacar(double valor)
        {
            if ((Saldo - valor) < 0)
                throw new InvalidOperationException("Conta Corrente " + NumeroConta + " possui saldo insuficiente para realizar este saque.");

            Saldo -= valor - TaxaOperacao;
        }
    }
}
