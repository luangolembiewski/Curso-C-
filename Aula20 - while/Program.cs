using System;
namespace Aula20
{
    class Program
    {
        static void Main()
        {
            //e2 = logica da quantidade de repetição

            // while(e1){
            // }

            int cont=0; //contador
            while(cont<10){
                Console.WriteLine("Vezes: "+cont);
                cont++;
            }

            int[] vet = new int[5];
            cont=0;
            while(cont<vet.Length){
                vet[cont]=cont;
                Console.WriteLine("Posição "+cont+": "+vet[cont]);
                cont++;
            }
            
        }
    }
}