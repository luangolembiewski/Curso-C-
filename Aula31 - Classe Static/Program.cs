using System;
namespace Aula30
{
    static public class Jogador{
        static public int energia,vida;
        static public string nome;
        static public void Iniciar(string n){                     
            energia=100;
            vida=100;
            nome=n;
        }

        static public void getInfo(){
            Console.WriteLine("Jogador {0}:[ vida:{1} , energia:{2} ]",nome,vida,energia);
        }
        
    }
    class Inimigo{
        static public bool alerta;                          //Definir static pra mexer com todos
        public string nome;
        public Inimigo(string n){
            alerta=false;
            nome=n;
        }
        public void getInfo(){
            Console.WriteLine(nome);
            Console.WriteLine(alerta);
            Console.WriteLine("-----------------------");
        }
    }
    class Program
    {
        static void Main()
        {
            Jogador.Iniciar("Luan");
            Jogador.getInfo();
            
            Inimigo x1= new Inimigo("Doido");
            Inimigo x2 = new Inimigo("Maluco");
            Inimigo x3 = new Inimigo("Pirado");
            Inimigo.alerta = true;                //Definindo o alerta de todos os inimigos true
            x1.getInfo();
            x2.getInfo();
            x3.getInfo();
        }
    }
}
 