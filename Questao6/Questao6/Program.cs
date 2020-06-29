using System;

namespace Questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("Crie uma aplicação, que demonstre a diferença entre REF e OUT.");
            Console.WriteLine("==============================================================");

            int x = 5;
            int y = 5;

            // Necessita inicializar o valor que vai entrar
            static void MetodoComRef(ref int paramX)
            {
                paramX += 1;
            }

            // Não necessita inicializar o valor que vai entrar, mas é necessario definir um valor dentro do método
            static void MetodoComOut(out int paramX)
            {
                //paramx += 1; Não é permitido
                // O valor somente pode sair
                paramX = 0;
            }

            MetodoComRef(ref x);
            // Mesmo inicializando em 5, vai retornar 0, pois é a saída do parâmetro com out
            MetodoComOut(out y);

            Console.WriteLine("Método usando ref obteve a saída {0}", x);
            Console.WriteLine("Método usando out obteve a saída {0}", y);

        }
    }
}
