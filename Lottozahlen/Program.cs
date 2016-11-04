using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottozahlen
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Random random = new Random();
            Program program = new Program();
            int[] lottozahlen = new int[6];

            //einfuegen Methode
            program.einfuegen(random, lottozahlen);           

            //sortiere Array
            Array.Sort(lottozahlen);

            //Ausgabe
            program.ausgabe(lottozahlen);
           
            Console.ReadKey();
        }

        public void einfuegen(Random random1, int[] zahlen)
        {
            for (int i = 0; i < 6; i++)
            {
                int rand = random1.Next(1, 50); //neue Zufallszahl im Wertebereich von 1 bis 49

                if (!zahlen.Contains(rand) && !rand.Equals(0))
                {
                    zahlen[i] = rand; //einfügen der Random Zahl in Array
                }
            }
        }

        public void ausgabe(int[] zahlen)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Zahl " + (i + 1) + ":   " + zahlen[i]);
            }
            Console.Write("\nEnde");
        }

    }
}
