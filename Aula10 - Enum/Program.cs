using System;
namespace Aula10
{
    class Program
    {
        enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
        static void Main()
        {
            DiasSemana ds = (DiasSemana)3; //converte para dias da semana

            int posicao = (int)DiasSemana.Quarta;



            Console.WriteLine(ds);
            Console.WriteLine(posicao);
        }
    }
}