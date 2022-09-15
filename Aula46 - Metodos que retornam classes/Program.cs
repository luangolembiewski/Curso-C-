using System;
class Program{
    static void Main(){
        Galinha g1 = new Galinha("Jestrudes");
        Galinha g2 = new Galinha("Jaqueline");
        g1.botar();
        g1.botar();
        g1.botar();
        g2.botar();
    }
}
 class Galinha{
    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha){
        this.nomeGalinha=nomeGalinha;
        this.numOvo=0;
    }
    public Ovo botar(){
        numOvo++;
        return new Ovo(numOvo,nomeGalinha);
    }
 }
 class Ovo{
    private int numOvo;
    private string minhaGalinha;
    public Ovo(int numOvo, string minhaGalinha){
        this.minhaGalinha=minhaGalinha;
        this.numOvo=numOvo;
        Console.WriteLine("Ovo criado! qtd:{0} - Galinha:{1}",this.numOvo,this.minhaGalinha);
    }
 }
 