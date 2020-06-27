using System;
using System.Collections.Generic;
using System.Text;

namespace Questao1POO
{
    abstract public class Animal
    {
        public string AcaoRealizada { get; set; }

        abstract public void Mover();
    }
}
