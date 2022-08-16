using System;
class Program{
    static void Main(){
        Carro c1 =new Carro();
    }
}
public interface Veiculo{
    //bool ligado;              //Erro (interface nao pode conter campos - somente metodos)
    void ligar();
    void desligar();
    void info();
}
public interface Combate{
    void disparar();
}
class Carro:Veiculo,Combate{             //implementa mais de uma interface
    public bool ligado;
    private int municao;
    public void ligar(){
        this.ligado=true;
    }
    public void desligar(){
        this.ligado=false;
    }
    public void info(){

    }
    public void disparar(){
        this.municao--;
    }
    public Carro(){
        this.municao=100;
    }
}