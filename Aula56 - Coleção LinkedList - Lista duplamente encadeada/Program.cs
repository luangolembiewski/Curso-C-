using System;
using System.Collections.Generic;
class Program{
    static void Main(){
        LinkedList<string> transp = new LinkedList<string>();
        transp.AddFirst("Carro");                           //adiciona na primeira chave
        transp.AddFirst("Moto"); 
        transp.AddLast("Bicicleta");                        //Adiciona na ultima chave
        LinkedListNode<string> no;
        no = transp.FindLast("Carro").Next;                 //Next pega o proximo
        transp.AddBefore(no,"Patinete");                    //Adiciona antes do valor passado
        transp.AddAfter(no,"Skate");                        //Adiciona apos o valor passado

        foreach(string s in transp){
            Console.WriteLine(s);
        }

        transp.Remove("Carro");    //limpar toda lista
        
        if(transp.Find("Carro")==null){
            Console.WriteLine("Carro Não encontrado");
        }else{
            Console.WriteLine("Carro esta na lista");
        }
        transp.Clear();    //limpar toda lista
        foreach(string s in transp){
            Console.WriteLine(s);
        }
    }
}