using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Questao1POO_Interfaces
{
    class Cozinheiro
    {
        public string Nome { get; set; }

        public Cozinheiro(string nome)
        {
            Nome = nome;
        }
    }

    class Restaurante : IEnumerable
    {
        Cozinheiro[] cozinheiros = new Cozinheiro[4];

        public Restaurante()
        {
            cozinheiros[0] = new Cozinheiro("André");
            cozinheiros[1] = new Cozinheiro("Mike");
            cozinheiros[2] = new Cozinheiro("Carlos");
            cozinheiros[3] = new Cozinheiro("Antonieta");
        }

        public IEnumerator GetEnumerator()
        {
            return cozinheiros.GetEnumerator();
        }
    }
}
