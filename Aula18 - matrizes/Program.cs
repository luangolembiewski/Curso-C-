using System;
namespace Aula18
{
    class Program
    {
        static void Main()
        {
            int[,] n = new int[2,5];   //matriz
            int[,] n2 = new int[2,2]{{10,20},{30,40}};   //matriz ja com valores

            // 10 20 30 40 50
            // 60 70 80 90 00
            n[0,0]=10; n[0,1]=20; n[0,2]=30; n[0,3]=40; n[0,4]=50;
            n[1,0]=60; n[1,1]=70; n[1,2]=80; n[1,3]=90; n[1,4]=00;

            Console.WriteLine(n2[1,1]);
        }
    }
}