using System;
class Program
{
    static void Main(){
        Carro c1 = new Carro("Fusion","Preto");
        Console.WriteLine("Modelo:{0}",c1.modelo);
        Console.WriteLine("Cor:...{0}",c1.cor);
        Console.WriteLine("Rodas:.{0}",c1.qtRodas);
        Console.WriteLine("velMax:{0}",c1.velMax);
        Console.WriteLine("Ligado:{0}",c1.getLigado());
        c1.ligar();
        Console.WriteLine("Ligado:{0}",c1.getLigado());
        c1.desligar();
        Console.WriteLine("Ligado:{0}",c1.getLigado());

    }
    
}

class Veiculo                      //classe heradada - Classe base
{
    public int qtRodas;
    public int velMax;
    private bool ligado;

    public void ligar(){
        Console.WriteLine("inhein inhein inhein inhein inhein Raaammm Raaammmm Raaammmm");
        ligado=true;
    }
    public void desligar(){
        Console.WriteLine("Raaammm Raaammm Raaammm Bululululu");
        ligado=false;
    }
    public string getLigado(){
        if(ligado==true){
            return "Sim";
        }else{
            return "Não";
        }
        
    }

}
class Carro:Veiculo                       //Herdando a classe - Classe derivada
{
    public string modelo;
    public string cor;
    public Carro(string modelo,string cor){
        qtRodas=4;
        velMax=200;
        this.modelo = modelo;
        this.cor = cor;
    }
}