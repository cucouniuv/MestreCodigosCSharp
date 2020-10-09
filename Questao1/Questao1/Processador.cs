namespace Questao1
{
    class Processador
    {
        private readonly double _valorA;
        private readonly double _valorB;

        public double Adicao() => (_valorA + _valorB);

        public double Subtracao() => (_valorA - _valorB);

        public double Divisao() => (_valorB / _valorA);

        public double Multiplicacao() => (_valorA * _valorB);

        public string ValorAEhParOuImpar => PegarTextoValorEhParOuImpar(_valorA);
        public string ValorBEhParOuImpar => PegarTextoValorEhParOuImpar(_valorB);

        private bool ValorEhPar(double valor)
        {
            return (valor % 2 == 0);
        }

        private string PegarTextoValorEhParOuImpar(double valor)
        {
            return ValorEhPar(valor) ? "Par" : "Ímpar";
        }

        public Processador(double valorA, double valorB)
        {
            _valorA = valorA;
            _valorB = valorB;
        }
    }
}
