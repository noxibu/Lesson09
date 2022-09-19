using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Sukurti struktūrą Studentas. 
 * Joje turi būti 3 sąrašai su trimestrų pažymiais. 
 * Struktūra turi turėti metodus trimestro vidurkiui ir metiniam pažymiui suskaičiuoti. */

namespace Lesson_9_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 2;
            List<int> list1 = new List<int> { 10, 10, 5 };
            List<int> list2 = new List<int> { 9, 4, 1};
            List<int> list3 = new List<int> { 7, 4, 5 };
            //Student studentas = new Student((2, 3, 4 ), ( 10, 10, 5), ( 5, 5, 9));

            Studentas studentas = new Studentas(list1, list2, list3);

            Console.WriteLine(studentas.TrimestroVidurkis(1));
            Console.WriteLine(studentas.TrimestroVidurkis(2));
            Console.WriteLine(studentas.TrimestroVidurkis(3));

            Console.WriteLine($"Metinis vidurkis yra { studentas.MetinisVidurkis()}");

        }

        public struct Studentas
        {
            public List<int> Trimester1;
            public List<int> Trimester2;
            public List<int> Trimester3;

            public Studentas(List<int> trimester1, List<int> trimester2, List<int> trimester3)
            {
                Trimester1 = trimester1;
                Trimester2 = trimester2;
                Trimester3 = trimester3;
            }

            public double TrimestroVidurkis(int trimestras)
            {
                double trimestroVidurkis = 0;
                switch (trimestras)
                {
                    case 1:
                        trimestroVidurkis = Trimester1.Average();
                        break;
                    case 2:
                        trimestroVidurkis = Trimester2.Average();
                        break;
                    case 3:
                        trimestroVidurkis = Trimester3.Average();
                        break;
                    default:
                        Console.WriteLine("Iveskite 1, 2 ar 3 trimestra");
                        break;
                }
                return trimestroVidurkis;
            }

            public double MetinisVidurkis()
            {
                double average1 = Trimester1.Average();
                double average2 = Trimester2.Average();
                double average3 = Trimester3.Average();

                double yearAverage = (average1 + average2 + average3) / 3;
                return yearAverage;
            }
        }
    }
}
