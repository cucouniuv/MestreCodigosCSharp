using System;
using System.Collections.Generic;
using System.Text;

namespace Questao1POO
{
    class Humano : Animal
    {
        public override void Mover()
        {
            AcaoRealizada = "Humano se moveu";
        }
    }
}
