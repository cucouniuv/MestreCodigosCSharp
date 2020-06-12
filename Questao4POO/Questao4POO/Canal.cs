using System;
using System.Collections.Generic;
using System.Text;

namespace Questao4POO
{
    public class Canal
    {
        /*private int _numero;
        private string _nome;

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }*/

        public int Numero { get; set; }
        public string Nome { get; set; }

        public Canal (int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

    }
}
