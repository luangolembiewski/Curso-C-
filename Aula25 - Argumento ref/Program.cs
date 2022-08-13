using System;
namespace Aula25
{
    class Program
    {
        static void Main()
        {
            int n = 1;     
            dobrar(n);      //metodo por valor(sem referencia)
            Console.WriteLine("Sem ref: "+n);      
            dobrarRef(ref n);      //metodo por referencia
            Console.WriteLine("Com ref: "+n);      
        }

        static void dobrar(int x){                     //metodo por valor(sem referencia)
            x*=2;
        }
        static void dobrarRef(ref int x){                     //metodo por referencia
            x*=2;
        }
        
    }
}