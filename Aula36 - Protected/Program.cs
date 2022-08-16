using System;
class Program
{
    static void Main(){
        Carro c1 = new Carro("Fusion",123);
        Console.WriteLine("Modelo:.....{0}",c1.modelo);
        Console.WriteLine("Vel. Max:...{0}",c1.getVelMax());
        Console.WriteLine("Ligado:.....{0}",c1.getLigado());
    }
}
class Veiculo                  
{
    public int velAtual;
    private int velMax;
    protected bool ligado;

    public Veiculo(int velMax){
        this.velAtual=0;
        this.velMax=velMax;
        this.ligado=false;
    }
    public bool getLigado(){
        return ligado;
    }
    public int getVelMax(){
        return velMax;
    }
   
}
class Carro:Veiculo                   
{
    public string modelo;
    public Carro(string modelo,int velMax):base(velMax){  //derivada de veiculo
        this.modelo = modelo;
        this.ligado = true;
    }
}
