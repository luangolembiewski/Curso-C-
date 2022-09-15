using System;
class Program{
    static void Main(){
        float area=0;
        
        try{
            area=Area.Quad(0,5F);
            Console.WriteLine("Area do quadrado: {0}",area);
        }catch(Exception e){
            Console.WriteLine("ERRO: {0}",e.Message);
        }finally{
            Console.WriteLine("Fim do processo!");
        }
    }
},
class Area{

    public static float Quad(float bas, float alt){
        if(bas<=0||alt<=0){
            throw new Exception("Base ou altura não pode ser igual ou menor que 0");        //Gerar uma exceção
        }
        return bas*alt;
    }
}