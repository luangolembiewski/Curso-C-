using System;
namespace Aula26
{
    class Program
    {
        static void Main()
        {
            int divid,divis,quoc,rest;
            divid = 10;
            divis = 3;
            quoc = divide(divid,divis,out rest);                        //out => permite mais de um retorno no metodo
            Console.WriteLine("{0}/{1}:{2} Resto:{3}",divid,divis,quoc,rest);
        }

        static int divide(int dividendo, int divisor, out int resto){    //out => permite mais de um retorno no metodo
            int quociente;
            quociente=dividendo/divisor;
            resto=dividendo%divisor;
            return quociente;
        }
    }
}