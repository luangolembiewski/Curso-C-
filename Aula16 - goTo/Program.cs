using System;
namespace Aula16
{
    class Program
    {
        static void Main()
        {
            string nome;
            int idade;
            string repeat;

            inicio:        // Volta para cá
            Console.Clear();
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nome: {0}",nome);
            Console.WriteLine("Idade: {0}",idade);
            Console.WriteLine("\nRepetir? sim/nao");
            repeat = Console.ReadLine().ToUpper();
            if(repeat.Equals("SIM")){
                goto inicio;
            }else{Console.WriteLine("\nFim");}

        }
    }
}