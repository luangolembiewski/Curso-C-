using System;
class Program{
    static void Main(){
        Carro c1=new Carro();
        // c1.marca="VW";
        // c1.modelo="Golf";
        // c1.cor="Branco";

        c1.info();

        Carro c2 = new Carro("Honda","HRV","Prata");   
        c2.info();

    }
}
struct Carro{                                   //STRUCT - Classe mais simples
    public string marca;
    public string modelo;
    public string cor;
    public Carro(string marca, string modelo, string cor){
        this.marca=marca;
        this.modelo=modelo;
        this.cor=cor;
    }
    public void info(){
        Console.WriteLine("Marca: {0}",marca);
        Console.WriteLine("Modelo: {0}",modelo);
        Console.WriteLine("Cor: {0}",cor);
    }
}

