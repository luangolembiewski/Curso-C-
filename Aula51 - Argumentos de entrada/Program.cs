using System;
class Program{
    static void Main(string[] args){
        int res=0;

        if(args.Length>0){
            Console.WriteLine("Qtd argumentos: {0}",args.Length);
            for(int i=0;i<args.Length;i++){
                res+=Int32.Parse(args[i]);
            }
            Console.WriteLine("Resultado da soma: {0}",res);
        }else{
            Console.WriteLine("Nenhum argumento foram passados");
        }
    }
}