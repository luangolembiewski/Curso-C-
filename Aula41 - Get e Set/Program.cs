using System;
class Program{
    static void Main(){
        Carro c1=new Carro();
        // Console.WriteLine("Velocidade Maxima: "+c1.vm);
        // c1.vm=200;
        // Console.WriteLine("Velocidade Maxima: "+c1.vm);
        Console.WriteLine("Velocidade Maxima: "+c1.velMax);
    }
}
class Carro{
    private int velMax;
    public int vm{                       //Propriedade usando accessor - ler e alterar sem precisar de dois metodos
        get{
            return velMax;
        }set{
            if(value<0){
                velMax=0;
            }else if(value>300){
                velMax=300;
            }else{
                velMax=value;
            }
        }
    }
    public Carro(){
        this.velMax=120;
    }

    
}