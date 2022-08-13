using System;
namespace Aula17
{
    class Program
    {
        static void Main()
        {
            int n1,n2,n3,n4;
            int[] n = new int[4];                    //Array  0-3
            int[] num = new int[4]{111,222,333,444}; //Array Ja com valores
            int[] nume = {111,222,333,444};          //Array sem precisar declarar tamanho

            n[0] = 111;
            n[1] = 222;
            n[2] = 333;
            n[3] = 444;

            Console.WriteLine(n[0]+" "+num[1]);
 
        }
    }
}