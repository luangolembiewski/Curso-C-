using System;
namespace Aula30
{
    public class Jogador{
        public int energia,vida;
        public string nome;
        public Jogador(){                     
            energia=100;
            vida=100;
            nome="Ronaldo";
        }
        public Jogador(string nome){                
            energia=100;
            vida=100;
            this.nome=nome;
        }
        public Jogador(string nome,int vida,int energia){                     
            this.nome=nome;
            this.vida=vida;
            this.energia=energia;
        }

        public void getInfo(){
            Console.WriteLine("Jogador {0}:[ vida:{1} , energia:{2} ]",nome,vida,energia);
        }
        
    }
    class Program
    {
        static void Main()
        {
            Jogador j1 = new Jogador();            
            Jogador j2 = new Jogador("Carlos");
            Jogador j3 = new Jogador("Luan",100,40);

            j1.getInfo();
            j2.getInfo();
            j3.getInfo();
        }
    }
}