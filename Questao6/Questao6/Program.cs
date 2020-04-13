using System;

namespace Questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crie uma aplicação, que demonstre a diferença entre REF e OUT.");

            Console.WriteLine("Informe um valor inteiro de entrada para o parâmetro:");
            //int x = int.Parse(Console.ReadLine());
            int x = 5;
            int y = 5;

            // Necessita inicializar o valor que vai entrar
            static void MetodoComRef(ref int paramx)
            {
                paramx += 1;
            }

            // Não necessita inicializar o valor que vai entrar, mas é necessario definir um valor dentro do metodo
            static void MetodoComOut(out int paramx)
            {
                //paramx += 1; Não é permitido
                // O valor somente pode sair
                paramx = 0;
            }

            MetodoComRef(ref x);
            MetodoComOut(out y);

            Console.WriteLine("Método usando ref obteve a saída {0}", x);
            Console.WriteLine("Método usando out obteve a saída {0}", y);

        }
    }
}
