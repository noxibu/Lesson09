using System;
using System.Collections.Generic;
using System.Linq;
/* Sukurti struktūrą Rinkėjas. 
* Rinkėjas turi ID ir požymį, kad prabalsavo. 
* Sukurti rinkėjų sąrašą. 
* Atsitiktiniu būdu į sąrašą pridėti 10 rinkėjų. 
* Parodyti balsavimo statistiką. */
namespace Lesson_09_06
{
    internal class Program
    {   public struct Rinkejas
        {
            public int VoterId;
            public bool Voted;

            public Rinkejas(int voterId, bool voted)
            {
                VoterId = voterId;
                Voted = voted;
            }

        }

        static void VoterStatistic(List<Rinkejas> rinkejai)
        {
            List<bool> rinkejasBalsavo = new List<bool>();
            foreach(Rinkejas r in rinkejai)
            {
                rinkejasBalsavo.Add(r.Voted);
            }

            double average = rinkejasBalsavo.Average(item => item ? 1.0 : 0.0);
            Console.WriteLine(average);

        }

        static bool RandomBool()
        {   Random randNum = new Random();
            bool randomBoolean = false;
            if (randNum.Next(1, 100) < 50)
            {
                randomBoolean = true;
            } 
                    return randomBoolean;
        }
        static void Main(string[] args)
        {
            List<Rinkejas> rinkejai = new List<Rinkejas>();
            Random rand = new Random();
            Rinkejas rinkejas1 = new Rinkejas(rand.Next(10, 20), RandomBool());
            Rinkejas rinkejas2 = new Rinkejas(rand.Next(21, 30), RandomBool());
            Rinkejas rinkejas3 = new Rinkejas(rand.Next(31, 40), RandomBool());
            Rinkejas rinkejas4 = new Rinkejas(rand.Next(41, 50), RandomBool());
            Rinkejas rinkejas5 = new Rinkejas(rand.Next(51, 60), RandomBool());
            Rinkejas rinkejas6 = new Rinkejas(rand.Next(61, 70), RandomBool());
            Rinkejas rinkejas7 = new Rinkejas(rand.Next(71, 80), RandomBool());
            Rinkejas rinkejas8 = new Rinkejas(rand.Next(81, 90), RandomBool());
            Rinkejas rinkejas9 = new Rinkejas(rand.Next(91, 99), RandomBool());
            Rinkejas rinkejas10 = new Rinkejas(rand.Next(100, 150), RandomBool());

            rinkejai.Add(rinkejas1);
            rinkejai.Add(rinkejas2);
            rinkejai.Add(rinkejas3);
            rinkejai.Add(rinkejas4);
            rinkejai.Add(rinkejas5);
            rinkejai.Add(rinkejas6);
            rinkejai.Add(rinkejas7);
            rinkejai.Add(rinkejas8);
            rinkejai.Add(rinkejas9);
            rinkejai.Add(rinkejas10);

            VoterStatistic(rinkejai);








        }
    }
}
