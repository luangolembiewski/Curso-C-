using System;
class Program{ 
    static void Main()
    {
        Base Ref;                                 //Ref => palavra chave para usar como referencia
        Derivada1 derivada1 = new Derivada1();                
        Derivada2 derivada2 = new Derivada2();      
        Ref=derivada1;                              //Passando o metodo pra referencia
        Ref.info();                                 //Exibindo metodo da referencia
        Ref=derivada2;
        Ref.info();                      
    }
}
class Base{
    public Base(){
        Console.WriteLine("Construtor da classe Base");
    }
    virtual public void info(){                    //metodo com nome info na base - VIRTUAL = escreve na base
        Console.WriteLine("Base");
    }
}
class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da classe Derivada1");
    }
    override public void info(){                    //metodo com nome info na Derivada 1 - OVERRIDE = sobrescreve na derivada1
        Console.WriteLine("Derivada 1");
    }
}
class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da classe Derivada2");
    }
    override public void info(){                    //metodo com nome info na Derivada 2 - OVERRIDE = sobrescreve na derivada2
        Console.WriteLine("Derivada 2");
    }
}