using System;
namespace Aula19
{
    class Program
    {
        static void Main()
        {
            //e1 = inicializador
            //e2 = logica da quantidade de repetição
            //e3 = ação

            // for(e1;e2;e3){
            // }

            for(int x=0;x<10;x++){
                Console.WriteLine("Vezes: "+ x);
            }

            int[] vet = new int[10];
            for(int x=0;x<10;x++){
                vet[x]= x;
            }
            for(int x=0;x<vet.Length;x++){
                Console.Write(vet[x]+"-");
            }
            
        }
    }
}