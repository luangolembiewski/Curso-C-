using System;
using System.Collections.Generic;
class Program{
    static void Main(){
        //string[]v={"Carro","Moto","Navio","Bicicleta"};
        //Queue<string> veiculos = new Queue<string>(v);                        //adicionar valores passando um array
        Queue<string> veiculos = new Queue<string>();
        veiculos.Enqueue("Carro");                                              //adiciona valores ao final da fila
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Bicicleta");

        Console.WriteLine("Tamanho Fila: {0}",veiculos.Count);
        if(veiculos.Contains("Navio")){                                         //procurar se valor contem na fila - return true or false
            Console.WriteLine("Navio está na fila");
        }else {
            Console.WriteLine("Navio não esta fila");
        }
        Console.WriteLine("Primeiro Veiculo: " + veiculos.Peek());              //Exibe o primeiro item
        Console.WriteLine("Primeiro Veiculo: " + veiculos.Dequeue());           //Exibe e deleta o primeiro item
        Console.WriteLine("Tamanho Fila: {0}",veiculos.Count);
        

        foreach(string s in veiculos){                                       //Exibe todos os itens da lista
            Console.WriteLine(s);
        }


        //veiculos.Clear();                                                     //Deleta todos os itens da fila
        Console.WriteLine("Tamanho Fila: {0}",veiculos.Count);
        

    }
}