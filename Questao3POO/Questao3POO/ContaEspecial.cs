using System;

namespace Questao3POO
{
    public class ContaEspecial : ContaBancaria, IImprimivel
    {
        public double Limite { get; set; }

        public override void Depositar(double valor)
        {
            Saldo += valor;
        }

        public string MostrarDados()
        {
            string dados = "Conta Especial " + NumeroConta;
            dados += " possui Saldo: " + Saldo.ToString("N2");

            return dados;
        }

        public override void Sacar(double valor)
        {
            if ((Saldo - valor) < (- Limite))
                throw new InvalidOperationException("Conta Especial " + NumeroConta + " possui saldo insuficiente para realizar este saque.");

            Saldo -= valor;
        }
    }
}
