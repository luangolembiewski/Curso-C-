using System;
using System.Collections.Generic;
class Program{
    static void Main(){
        List<string> carros= new List<string>();
        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argos");

        List<string> carros2= new List<string>();
        string[] carros3= new string[10];

        carros2.AddRange(carros);                                           //Transferir de uma lista para outra

        
        if(carros.Contains("Golf")){                                        //procurar se valor contem na lista - return true or false
            Console.WriteLine("Carro está na lista");
        }else {
            Console.WriteLine("Carro não esta lista");
        }


        carros.CopyTo(carros3,2);                                           //copiar a partir da posição

        string car ="HRV";
        int pos=0;
        pos=carros.IndexOf(car);                                            //posição do valor pesquisado
        Console.WriteLine("Carro {0} esta na posição {1}",car,pos);

        //carros.Clear();                                                   //Limpar lista


        foreach(string s in carros){        //percorrer lista toda
            Console.WriteLine(s);
        }
        Console.WriteLine("===============");
        foreach(string s in carros2){
            Console.WriteLine(s);
        }
        Console.WriteLine("===============");
        foreach(string s in carros3){
            Console.WriteLine("Carros:" + s);
        }
    }

}