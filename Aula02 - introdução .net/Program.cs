using System;
namespace Aula02{
    class Program{
        static void Main(string[] args)
        {
            //Tipos dr Variáveis locais
            byte n1 = 10; // 0 e 255
            int num = -10;
            char letra = 'c';
            float valor = 5.3f;
            string nome = "Bruno";

            var aux = nome; //é definido tipo automaticamente

            Console.WriteLine("Nome: " + aux);

            int num1,num2,num3;
            num1 = 1;
            num2 = 2;
            num3 = num1*num2;
            var x = "A Multiplicação de "+num1+"x"+num2+"="+num3;

            Console.WriteLine(x);
        }
    }
}