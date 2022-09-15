using System;
class Program{
    static void Main(){
        Calc calc = new Calc();
        var res = calc.fat(5);                        //fatorial de 5
        Console.WriteLine("Resultado: {0}",res);
    }
    
}
class Calc{
    public int fat(int n){  //fatorial 5! = 5*4*3*2*1
        int res;
        if(n<=1){               //Controle de parada
            res = 1;
        }else{
            res = n*fat(n-1);   //Recursividade 
        }
        return res;
    }
}