using System;

namespace Atividade_Técnica
{
    class Program
    {
        static void Main(string[] args)

            {

            Grupotecnico g1 = new Grupotecnico("Piloto", "ofc1", "ofc2");

            GrupoCabine g2 = new GrupoCabine("Chefe", "com1", "com2");

            GrupoJudicial g3 = new GrupoJudicial("Policial","Presidiario")


            Console.WriteLine(g1.ToString());

            Console.WriteLine(g2.ToString());

            Console.WriteLine(g3.ToString());

        }





    }
}
