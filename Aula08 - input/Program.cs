using System;
namespace Aula08
{
    class Program
    {
        static void Main()
        {
            string nome;
            int idade;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua idade:");
            idade = int.Parse(Console.ReadLine()); //parse ou tryParse
            idade = Convert.ToInt32(Console.ReadLine()); //Convert

            Console.Write("Nome: {0}",nome);
            Console.Write("Idade: {0}",idade);
        }
    }
}