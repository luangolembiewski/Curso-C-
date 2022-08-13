using System;
namespace Aula11
{
    class Program
    {
        static void Main()
        {
            int n1=10;
            float n2=n1;  //conversão segura(int para float)

            float n3=10.5f;
            int n4=(int)n3;  //conversão explicita(float para int) (TapeCast (int))

            Console.WriteLine(n2); 
        }
    }
}