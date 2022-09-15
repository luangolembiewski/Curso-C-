using System;
namespace Calc1{        //NAMESPACE: classificar classes por tipos
    class Area{
        public static float Quad(float bas, float alt){
            if(bas<=0||alt<=0){
                throw new Exception("Base ou altura não pode ser igual ou menor que 0");        //Gerar uma exceção
            }
            return bas*alt;
        }
    }
}
namespace Calc2{        //NAMESPACE 2: para ter duas classes com nomes iguais
    class Area{
        public static float Quad(float bas, float alt){
            if(bas<=0||alt<=0){
                throw new Exception("Base ou altura não pode ser igual ou menor que 0");        //Gerar uma exceção
            }
            return bas*alt;
        }
    }
}
class Program{
    static void Main(){
        float area=0;
        
        try{
            area=Calc1.Area.Quad(10F,5F);
            Console.WriteLine("Area do quadrado: {0}",area);
        }catch(Exception e){
            Console.WriteLine("ERRO: {0}",e.Message);
        }finally{
            Console.WriteLine("Fim do processo!");
        }
    }
}
