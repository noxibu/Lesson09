using System;

namespace Lesson09_03
{
    internal class Program

    {   public struct Staciakampis
        {
            public int Ilgis;
            public int Plotis;

            public Staciakampis(int ilgis, int plotis)
            { 
                Ilgis = ilgis; 
                Plotis = plotis;
            }

            public int Plotas()
            {
                int plotas = Plotis * Ilgis;
                return plotas;
            }
        }
        
        static void Main(string[] args)
        {
            Staciakampis staciakampis1 = new Staciakampis(10, 10);
            Staciakampis staciakampis2 = new Staciakampis(5, 4);
            Staciakampis staciakampis3 = new Staciakampis(9, 9);

            Console.WriteLine($"Staciakampio plotas {staciakampis1.Plotas()}");
            Console.WriteLine($"Staciakampio plotas {staciakampis2.Plotas()}");
            Console.WriteLine($"Staciakampio plotas {staciakampis3.Plotas()}");
        }
    }
}
