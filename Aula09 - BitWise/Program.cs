using System;
namespace Aula09
{
    class Program
    {
        static void Main()
        {
            // << (bitWise esquerda) -> Dobra 
            // >> (bitWise direita) -> Metade
            //    00001010     = 10
            // << 00010100     = 20  
            // >> 00010100     = 5  

            int num1 = 10;
            Console.WriteLine("Numero: {0}",num1);
            Console.WriteLine("<<: {0}",num1<<1);
            Console.WriteLine(">>: {0}",num1>>1);
            Console.WriteLine("<<3: {0}",num1<<3);
            Console.WriteLine(">>3: {0}",num1>>3);
        }
    }
}