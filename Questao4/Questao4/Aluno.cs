using System.Linq;

namespace Questao4
{
    class Aluno
    {
        public string Nome { get; set; }
        public double[] Notas { get; set; }
        public double Media => PegarMedia();

        double PegarMedia()
        {
            double somaNotas = Notas.ToList().Sum();
            return (somaNotas / Notas.Count());
        }

        public Aluno(string nome, double[] notas)
        {
            Nome = nome;
            Notas = (double[])notas.Clone();
        }
    }
}
