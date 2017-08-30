using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlienZoo
{
    class AlienBreedingSims
    {
        int days;
        public AlienBreedingSims(int days)
        {
            Console.WriteLine("Please input the simulation days: ");
            this.days = days;
        }
        //int Randomclas()
        //{
        //    Random rand = new Random();
        //    if (rand.NextDouble() >= 0.5) ;
        //}

        public static void Sims()
        {
            bool isSimsOn = true;
            Creatures[] Creature = new Creatures[15];
            // List <T>
            try
            {
                int index = 0;
                while (isSimsOn)
                {
                    // Creature[index] = Random
                }
            }
            catch (Exception e)
            {

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please input the simulation days: ");
            new AlienBreedingSims(int.Parse(Console.ReadLine()));
            Sims();
        }
    }
    abstract class Creatures
    {

    }
    class Ayam : Creatures
    {
        public bool IsAllowMate
        {
            get; set;
        }
        public float matingChance
        {
            get { return 1; }
        }

    }
    class Bixam : Creatures
    {
        public bool IsAllowMate
        {
            get; set;
        }
        public float matingChance
        {
            get { return 1 / 3; }
        }
    }

}

