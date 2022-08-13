using System;
namespace Aula28
{
    public class Jogador{
        public int energia=100;
        public int vida=100;
    }
    class Program
    {
        static void Main()
        {
            Jogador j1 = new Jogador();              //instanciar um objeto NEW=cria um espaço na memoria
            Jogador j2 = new Jogador();

            Console.WriteLine("Jogador 1:[ vida:{0} , energia:{1} ]",j1.vida,j1.energia);
            Console.WriteLine("Jogador 2:[ vida:{0} , energia:{1} ]",j2.vida,j2.energia);
            Console.ReadLine();
            Console.WriteLine("Jogador1 Socou o Jogador2");
            Console.ReadLine();
            j1.energia -= 40;                         
            j2.vida -= 30;
            Console.WriteLine("Jogador 1:  [ vida:{0} , energia:{1} ]",j1.vida,j1.energia);
            Console.WriteLine("Jogador 2:  [ vida:{0} , energia:{1} ]",j2.vida,j2.energia);
            Console.ReadLine();
            Console.WriteLine("Jogador2 Chutou o Jogador1");
            Console.ReadLine();
            j2.energia -= 50;                         
            j1.vida -= 50;
            Console.WriteLine("Jogador 1:  [ vida:{0} , energia:{1} ]",j1.vida,j1.energia);
            Console.WriteLine("Jogador 2:  [ vida:{0} , energia:{1} ]",j2.vida,j2.energia);
            Console.ReadLine();
            Console.WriteLine("Jogador1 Bicudou o Jogador2");
            Console.ReadLine();
            j1.energia -= 50;                         
            j2.vida -= 70;
            Console.WriteLine("Jogador 1:  [ vida:{0} , energia:{1} ]",j1.vida,j1.energia);
            Console.WriteLine("Jogador 2:  [ vida:{0} , energia:{1} ]",j2.vida,j2.energia);
            Console.WriteLine("Jogador 2:  [ MORREU ]");
            Console.ReadLine();
        }
    }
}