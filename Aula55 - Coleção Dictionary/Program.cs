using System;
using System.Collections.Generic;  //adicionar extenção
class Program{
    static void Main(){
        Dictionary <int,string> veiculos = new Dictionary <int,string>();

        veiculos.Add(10,"Carro");
        veiculos.Add(5,"Avião");
        veiculos.Add(0,"Navio");
        veiculos.Add(20,"Moto");
        veiculos.Add(15,"Patinete");

        int chave=20;
        string valor="Navio";
        if(veiculos.ContainsKey(chave)){                                    //busca se a chave existe - return true or false
            Console.WriteLine("A chave {0} esta na coleção",chave);
        }else {
            Console.WriteLine("A chave {0} não esta na coleção",chave);
        }
        if(veiculos.ContainsValue(valor)){                                  //busca se o valor existe - return true or false
            Console.WriteLine("{0} esta na coleção",valor);
        }else {
            Console.WriteLine("{0} não esta na coleção",valor);
        }

        veiculos.Remove(chave);                                             //remove por chave
        veiculos[15]="Bicicleta";                                           //Substitui valor

        Dictionary<int,string>.ValueCollection valores=veiculos.Values;     //Exibir todos os valores FORMA 1
        foreach(string s in valores){                                       //Exibir todos os valores FORMA 1
            Console.WriteLine(s);
        }
        foreach(KeyValuePair<int,string> s in veiculos){                    //Exibir todos os valores FORMA 2
            Console.WriteLine(s.Value);
        }



        Console.WriteLine("Tamanho: {0}",veiculos.Count);                   //Exibe tamanho do Dictonary
        veiculos.Clear();                                                   //Limpa o Dictionary
        Console.WriteLine("Tamanho: {0}",veiculos.Count);
        
        
        
    }
}