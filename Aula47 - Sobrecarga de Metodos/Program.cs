using System;
class Program{
    static void Main(){
        Calc calc=new Calc();
        double res =0;
        res=calc.soma(1,2);
        Console.WriteLine("Com inteiro: "+res);
        res=calc.soma(1.5,2.3);
        Console.WriteLine("Com double: "+res);
        //res=calc.soma(1,2,5);         //sobrecarga
        //Console.WriteLine(res);

    }
}
class Calc{
    public int soma(params int[]n){
        int res=0;
        if(n.Length<1){
            Console.WriteLine("Não existe valores a serem somados");
        }else if(n.Length<2){
            Console.WriteLine("Valores insuficientes para soma");
        }else{
            for(int i=0;i<n.Length;i++){
                res+=n[i];
            }
            Console.WriteLine("A soma dos valores é: {0}", res);
        }
        
        return res;
    }
    public double soma(params double[]n){
        double res=0;
        if(n.Length<1){
            Console.WriteLine("Não existe valores a serem somados");
        }else if(n.Length<2){
            Console.WriteLine("Valores insuficientes para soma");
        }else{
            for(int i=0;i<n.Length;i++){
                res+=n[i];
            }
            Console.WriteLine("A soma dos valores é: {0}", res);
        }
        
        return res;
    }
    //public int soma(int n1, int n2,int n3){  //sobrecarga
    //    return n1+n2+n3;
    //}
}