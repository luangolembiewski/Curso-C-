using System;
class Program{
    static void Main(){
        Carro c1=new Carro();
        Console.WriteLine("Velocidade Maxima: "+c1[4]);
        c1[4]+=200;
        Console.WriteLine("Velocidade Maxima: "+c1[4]);         
    }
}
class Carro{
    private int[] velMax=new int[5]{10,20,30,40,50};
    public int this[int i]{                       //indexador = permite o objeto ser usado como um array
        get{
            return velMax[i];
        }set{
            if(value<0){
                velMax[i]=0;
            }else if(value>300){
                velMax[i]=300;
            }else{
                velMax[i]=value;
            }
        }
    }
    public Carro(){
    }

    
}