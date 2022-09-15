using System;
class Program{
    static void Main(){

        //Mat m1 = new Mat();       //Não precisa usar isso pois os metodos e variaveis são estaticas
        double vpi = Mat.pi;
        
        Console.WriteLine("Pi: {0}",vpi);
        int num = 10;
        Console.WriteLine("Dobro: {0}",Mat.dobro(num));
    }
}
class Mat{
    public static double pi =3.14;
    public static int dobro(int n){
        return n*2;
    }
}