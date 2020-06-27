using System;
using System.Collections.Generic;
using System.Text;

namespace Questao1POO
{
    public class Cachorro : Animal, IHumorBom, IHumorRuim
    {
        // Polimorfismo
        public override void Mover()
        {
            // Encapsulamento
            Latir();

            if (AcaoRealizada.Length == 0)
                AcaoRealizada = "Cachorro se moveu";
            else
                AcaoRealizada += " e se moveu";
        }

        void IHumorBom.ExecutarAlgo()
        {
            AcaoRealizada = "Cachorro brincou com uma criança";
        }

        void IHumorRuim.ExecutarAlgo()
        {
            AcaoRealizada = "Cachorro mordeu o carteiro";
        }

        private void Latir()
        {
            AcaoRealizada = "Cachorro latiu";
        }
    }
}
