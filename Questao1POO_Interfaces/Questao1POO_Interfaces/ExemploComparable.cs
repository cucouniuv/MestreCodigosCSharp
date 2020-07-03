using System;
using System.Collections.Generic;
using System.Text;

namespace Questao1POO_Interfaces
{
    class Funcionario: IComparable
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public int CompareTo(object obj)
        {
            Funcionario funcionario = obj as Funcionario;

            if (funcionario == null)
            {
                throw new NullReferenceException("Objeto Funcionario nulo.");
            }

            return this.Nome.CompareTo(funcionario.Nome);
        }
    }
}
