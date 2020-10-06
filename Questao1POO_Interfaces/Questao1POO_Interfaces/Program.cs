using System;

namespace Questao1POO_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecutarExemploIComparable();
            Console.WriteLine("");
            ExecutarExemploICloneable();
            Console.WriteLine("");
            ExecutarExemploIEnumerable();
            Console.WriteLine("");
            ExecutarExemploIDisposable();
        }

        private static void ExecutarExemploIComparable()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Exemplo com IComparable");
            Console.WriteLine("=======================");

            Funcionario[] funcionarios = new Funcionario[4];
            funcionarios[0] = new Funcionario() { Codigo = 1, Nome = "Ronaldo" };
            funcionarios[1] = new Funcionario() { Codigo = 5, Nome = "Zidane" };
            funcionarios[2] = new Funcionario() { Codigo = 3, Nome = "Pelé" };
            funcionarios[3] = new Funcionario() { Codigo = 2, Nome = "Maradona" };

            // Irá ordenar a lista de funcionários pelo Nome
            Array.Sort(funcionarios); // Sem o Icomparable iria ocorrer um erro

            foreach (Funcionario f in funcionarios)
            {
                Console.WriteLine(f.Nome);
            }
        }

        private static void ExecutarExemploICloneable()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Exemplo com ICloneable");
            Console.WriteLine("=======================");

            Carro carroA = new Carro();
            carroA.Nome = "Corsa";
            carroA.Modelo = "Sedan 4 portas";
            carroA.MotorObjeto.Nome = "6 cilindros";

            Console.WriteLine("Dados do Carro A:");
            Console.WriteLine(
                String.Format("Carro {0}, modelo {1} e motor {2}", 
                    carroA.Nome, carroA.Modelo, carroA.MotorObjeto.Nome));

            Carro carroBClonado = (Carro)carroA.Clone();

            Console.WriteLine("");
            Console.WriteLine("Dados do Carro B, clonado superficialmente de A:");
            Console.WriteLine(
                String.Format("Carro {0}, modelo {1} e motor {2}",
                    carroBClonado.Nome, carroBClonado.Modelo, carroBClonado.MotorObjeto.Nome));

            Console.WriteLine("");
            Console.WriteLine("Alterado o nome do motor de B para demonstrar a cópia superficial");
            carroBClonado.MotorObjeto.Nome = "12 cilindros";

            Console.WriteLine("");
            Console.WriteLine("Dados do Carro A após alteração do motor em B:");
            Console.WriteLine(
                String.Format("Carro {0}, modelo {1} e motor {2}",
                    carroA.Nome, carroA.Modelo, carroA.MotorObjeto.Nome));

            Console.WriteLine("");
            Console.WriteLine("Agora com clonagem profunda e alterado posteriormente o motor de B");
            carroA.Nome = "Corsa";
            carroA.Modelo = "Sedan 4 portas";
            carroA.MotorObjeto.Nome = "6 cilindros";

            carroBClonado = (Carro)carroA.DeepClone();
            carroBClonado.MotorObjeto.Nome = "12 cilindros";

            Console.WriteLine("");
            Console.WriteLine("Dados do Carro A:");
            Console.WriteLine(
                String.Format("Carro {0}, modelo {1} e motor {2}",
                    carroA.Nome, carroA.Modelo, carroA.MotorObjeto.Nome));

            Console.WriteLine("");
            Console.WriteLine("Dados do Carro B, clonado profundamente de A:");
            Console.WriteLine(
                String.Format("Carro {0}, modelo {1} e motor {2}",
                    carroBClonado.Nome, carroBClonado.Modelo, carroBClonado.MotorObjeto.Nome));


        }

        private static void ExecutarExemploIEnumerable()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Exemplo com IEnumerable");
            Console.WriteLine("=======================");

            Restaurante restaurante = new Restaurante();

            foreach(Cozinheiro c in restaurante)
            {
                Console.WriteLine(c.Nome);
            }
        }

        private static void ExecutarExemploIDisposable()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Exemplo com IDisposable");
            Console.WriteLine("=======================");

            Coisa coisa = new Coisa();
            try
            {
                Console.WriteLine("Criado objeto Coisa e após o seu uso é chamado o Dispose para liberar os objetos Timer e Stream.");
            }
            finally
            {
                coisa.Dispose();
            }            
        }
    }
}
