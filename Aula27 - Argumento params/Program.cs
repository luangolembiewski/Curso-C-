using System;
namespace Aula27

{
    class Program
    {
        static void Main()
        {
            soma();
            soma(1,3);
            soma(1,3,5,1);
        }

        static void soma(params int[]n){    //params => permite enviar array(ou varios valores) sem especificar quantos esta passando
           int res=0;

           if(n.Length<1){
                Console.WriteLine("Não exitem valores a serem somados");
           }else if(n.Length<2){
                Console.WriteLine("Valores insuficientes para ser lidos");
           }else{
                for(int i =0;i<n.Length;i++){
                    res+=n[i];
                }
                Console.WriteLine("Soma: {0}",res);
           }
        }
    }
}