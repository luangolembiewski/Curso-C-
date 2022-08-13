using System;
namespace Aula29
{
    public class Jogador{
        public int energia;
        public int vida;
        public string nome;
        public Jogador(string n){                       //Metodo Construtor
            energia=100;
            vida=100;
            nome=n;
        }
        ~Jogador(){                                     //Metodo Destrutor(Destroi todos que estiver instanciados)
            Console.WriteLine("Jogador {0} foi eliminado",nome);  
        }
    }
    class Program
    {
        static void Main()
        {
            Jogador j1 = new Jogador("Luan");            
            Jogador j2 = new Jogador("Carlos");

            j1.energia=70;
            j2.vida=50;
            Console.WriteLine("Jogador {0}:[ vida:{1} , energia:{2} ]",j1.nome,j1.vida,j1.energia);
            Console.WriteLine("Jogador {0}:[ vida:{1} , energia:{2} ]",j2.nome,j2.vida,j2.energia);
        }
    }
}