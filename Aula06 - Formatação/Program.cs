using System;
namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quebra de texto \nTabulação:\t espaço"); // \n=quebra de linha - \t=tabulação(espaço grande)

            double valorCompra=5.50;
            double valorVenda;
            double lucro=0.1;
            string produto="Pastel";

            valorVenda =valorCompra+(valorCompra*lucro);

            Console.WriteLine("Produto...................{0,10}",produto);           //,10  Formatar a direita
            Console.WriteLine("Val.Compra................{0,10:c}", valorCompra);    // :c  monetario
            Console.WriteLine("Lucro.....................{0,10:p}", lucro);          //:p   Porcentagem
            Console.WriteLine("Val. Venda................{0,10:c}", valorVenda);
        }
    }
}