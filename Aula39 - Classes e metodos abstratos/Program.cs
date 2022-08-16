using System;
class Program{
    static void Main(){
        Carro c1 = new Carro();
        Console.WriteLine(c1.getVelAtual());
        c1.Aceleracao(2);
        Console.WriteLine(c1.getVelAtual());
        c1.Aceleracao(-1);
        Console.WriteLine(c1.getVelAtual());
    }
}
abstract class Veiculo{      //classe abstrata
    protected int velMax;
    protected int velAtual;
    protected bool ligado;

    public Veiculo(){
        ligado=false;
        velAtual=0;
    }
    public void setLigado(bool ligado){
        this.ligado = ligado;
    }
    public int getVelAtual(){
        return velAtual;
    }
    abstract public void Aceleracao(int multiplicador);        //Abstrato obrigado a implementar porem não pode ser implementado aqui
} 
class Carro:Veiculo{
    public Carro(){
        velMax=120;
    }
    override public void Aceleracao(int multiplicador)
    {
        velAtual+=10*multiplicador;
    }
}