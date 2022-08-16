using System;
class Program{
    static void Main(){
        Carro[] carros=new Carro[3];  
        carros[0].modelo="HRV";
        carros[0].cor="Prata";
        carros[1].modelo="HB20";
        carros[1].cor="Vinho";
        carros[2].modelo="Golf";
        carros[2].cor="Branco";

        for(int x=0; x<carros.Length;x++){
            carros[x].info();
        }
        
    }
}
struct Carro{                                   //STRUCT - Classe mais simples
    public string modelo;
    public string cor;
    
    public void info(){
        Console.WriteLine("Modelo: {0}",modelo);
        Console.WriteLine("Cor: {0}",cor);
        Console.WriteLine("----------------------");
    }
}

