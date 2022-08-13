using System;
namespace Aula22
{
    class Program
    {
        static void Main()
        {
            int[] vet = new int[5]{10,20,30,40,50};
            
            for(int x=0;x<vet.Length;x++){
                Console.WriteLine("Pos"+x+":"+vet[x]);
            }

            foreach(int x in vet){ //Percorre todo o vetor jogando o valor de cada no X
                Console.WriteLine("Pos"+x+":"+vet[x]);
            }
        }
    }
}