using System;
class Program
{
    static void Main(){
        CarroCombate c1 = new CarroCombate();
        Console.WriteLine("Modelo:{0}",c1.modelo);
        Console.WriteLine("Cor:...{0}",c1.cor);
        Console.WriteLine("Rodas:.{0}",c1.getQtRodas());
        Console.WriteLine("velMax:{0}",c1.velMax);
        Console.WriteLine("Ligado:{0}",c1.getLigado());
        //c1.ligar();
        //Console.WriteLine("Ligado:{0}",c1.getLigado());
        //c1.desligar();
        //Console.WriteLine("Ligado:{0}",c1.getLigado());
    }
}
class Veiculo                  
{
    private int qtRodas;
    public int velMax;
    private bool ligado;

    public Veiculo(int qtRodas){
        this.qtRodas = qtRodas;
    }

    public void ligar(){
        Console.WriteLine("inhein inhein inhein inhein inhein Raaammm Raaammmm Raaammmm");
        ligado=true;
    }
    public void desligar(){
        Console.WriteLine("Raaammm Raaammm Raaammm Bululululu");
        ligado=false;
    }
    public string getLigado(){
        return (ligado?"Sim":"Não");           //semplificar o retorno se for binario - Operador ternário
    }
    public void setQtRodas(int qtRodas){
        if(qtRodas<0){
            this.qtRodas=0;
        }else if(qtRodas>40){
            this.qtRodas=40;
        }else{
            this.qtRodas=qtRodas;
        }
    }
    public int getQtRodas(){
        return qtRodas;
    }

}
class Carro:Veiculo                   
{

    public string modelo;
    public string cor;
    public Carro(string modelo,string cor):base(4){        //inicializando a variavel QTRODAS pelo construtor da derivada
        velMax=200;
        this.modelo = modelo;
        this.cor = cor;
    }
}
class CarroCombate:Carro{
    public int municao;
    public CarroCombate():base("CarroCombate","Rosa"){   //inicializando as variaveisque faltam pelo construtor da derivada
        municao=100;
        setQtRodas(6);
    }
}