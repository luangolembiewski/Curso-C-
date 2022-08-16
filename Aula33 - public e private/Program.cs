using System;
class Program
{
    static void Main(){
        Jogador j1 = new Jogador("Luan");

        j1.setEnergia(-20);
        j1.setEnergia(10);

        Console.WriteLine("Nome: {0}, energia: {1}",j1.getNome(),j1.getEnergia());
    }
}
class Jogador{
    private string nome;                    //private => Só é acessivel dentro da classe 
    private int energia;                    //private => Só é acessivel dentro da classe 
    public Jogador(string nome){
        this.nome=nome;
        this.energia=100;
    }
    public int getEnergia(){               //metodo que possibilita disponibilizar o valor da energia
        return energia;
    }
    public string getNome(){           
        return nome;
    }
    public void setEnergia(int energia){               //metodo que possibilita disponibilizar o valor da energia
        if(energia<0){
            if(this.energia+energia <0){
                this.energia=0;
            }else{
                this.energia+=energia;
            }
        }else if(energia>0){
            if(this.energia+energia>100){
                this.energia=100;
            }else{
                this.energia+=energia;
            }

        }
    }
}