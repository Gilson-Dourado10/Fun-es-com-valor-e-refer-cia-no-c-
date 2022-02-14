using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            dobrar(ref num);
            Console.WriteLine(num);
            imprime_linha();
        }

        static void imprime_linha()
        {
            Console.WriteLine("\n*****-------------*****---------------******\n");
        }

        static void dobrar(ref int valor)
        {
            valor *= 2;
        }
    }
}
