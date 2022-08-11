using System;
namespace Aula04
{
    class Program
    {
        static int num1 = 1; //variável global estatica 
        int num2 = 2; //variável global não estatica 
        static void Main()
        {
            Console.WriteLine("Main: "+num1);
            //Console.WriteLine(num2);  Erro
        }
        void metodo()
        {
            Console.WriteLine("Método: "+num1);
            Console.WriteLine("Método: "+num2);
        }
    }
}