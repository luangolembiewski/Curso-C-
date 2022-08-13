using System;
namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2, y = 1;
            Console.WriteLine("Adição: {0}+{1}={2}",x,y,(x+y));
            Console.WriteLine("Subtração: {0}-{1}={2}",x,y,(x-y));
            Console.WriteLine("Multiplicação: {0}x{1}={2}",x,y,(x*y));
            Console.WriteLine("Divisão: {0}/{1}={2}",x,y,(x/y));
        }
    }
}