using System;

namespace Questao1POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Humano humano = new Humano();
            Peixe peixe = new Peixe();
            Cachorro cachorro = new Cachorro();

            humano.Mover();
            peixe.Mover();
            cachorro.Mover();

            Console.WriteLine(String.Format("Animais instruídos a se mover: {0}, {1}, {2}", 
                humano.AcaoRealizada, peixe.AcaoRealizada, cachorro.AcaoRealizada));

            Cachorro cachorroLegal = new Cachorro();

            ((IHumorBom)cachorroLegal).ExecutarAlgo();

            Console.WriteLine(String.Format("O cachorro estava com humor bom e {0}", 
                cachorroLegal.AcaoRealizada));

            ((IHumorRuim)cachorroLegal).ExecutarAlgo();

            Console.WriteLine(String.Format("O cachorro estava com humor ruim e {0}",
                cachorroLegal.AcaoRealizada));
        }
    }
}
