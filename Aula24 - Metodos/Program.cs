using System;
namespace Aula24
{
    class Program
    {
        static void Main()
        {
            getNome();      //metodo
            adicao(5,3);      //metodo com argumentos
            Console.WriteLine("Subtração: "+subtraicao(5,3));      //metodo com argumentos e com retorno
        }

        static void getNome(){                     //metodo
            Console.WriteLine("Luan Golembiewski");
        }
        static void adicao(int n1,int n2){          //metodo com argumentos
            Console.WriteLine("Adição: "+(n1+n2));
        }
        static int subtraicao(int n1,int n2){
            return (n1-n2);                        //metodo com retorno
        }
    }
}