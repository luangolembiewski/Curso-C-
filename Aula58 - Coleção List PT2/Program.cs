using System;
using System.Collections.Generic;
class Program{
    static void Main(){
        List<string> carros= new List<string>();
        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");
        carros.Add("HRV");

        carros.Insert(1,"Cruze");                                   //inserir passando chave e valor
        int pos = carros.LastIndexOf("HRV");                        //retorna a posição do ultimo HRV na lista
        Console.WriteLine("Ultimo HRV esta na posição {0}",pos);
        int tamanho = carros.Count;
        Console.WriteLine("Tamanho da lista: {0}",tamanho);
        int cap = carros.Capacity;                                  //exibe a capacidade da lista
        Console.WriteLine("capacidade da lista: {0}",cap);
        carros.Capacity = 15;                                       //altera a capacidade da lista
        cap = carros.Capacity; 
        Console.WriteLine("capacidade da lista: {0}",cap);

        foreach(string s in carros){                                //percorrer lista toda
            Console.WriteLine(s);
        }
        Console.WriteLine("========================");
        carros.Remove("HRV");                                       //remover Por valor OBS: somente o primeiro
        foreach(string s in carros){                        
            Console.WriteLine(s);
        }
        Console.WriteLine("========================");

        carros.Reverse();                                           //Reverte a lista
        foreach(string s in carros){                        
            Console.WriteLine(s);
        }
        Console.WriteLine("========================");
        carros.Sort();                                              //Ordena a lista por ordem alfabetica
        foreach(string s in carros){                        
            Console.WriteLine(s);
        }
    }

}