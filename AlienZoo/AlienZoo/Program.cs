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
        public AlienBreedingSims()
        {

        }
        public static void Sims()
        {
            bool isSimsOn = true;
            int days = 0;
            Creatures[] Creature = new Creatures[15];
            try
            {
                int index = 0;

                Console.WriteLine("Please input the simulation days: ");
                days = int.Parse(Console.ReadLine());


                while (isSimsOn)
                {
                    Random rand = new Random();
                    if (rand.NextDouble() > 0.5)
                    {
                        Ayam freshman = new Ayam();
                        Creature[index] = freshman;
                    }
                    else
                    {
                        Bixam freshman = new Bixam();
                        Creature[index] = freshman;
                    }


                    if (index > 0)
                    {
                        for (int i = 0; i < 15; i++)
                        {
                            var typea = Creature[i].GetType();
                            if (Creature[i].IsAllowMate == true && typea == Creature[index].GetType() && )
                            {
                                
                            }
                        }
                    }


                    index++;


                    if (index == 14)
                    {
                        break;
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        static void Main(string[] args)
        {
            Sims();
        }
    }
    abstract class Creatures
    {
        public bool IsAllowMate
        {
            get; set;
        }
    }
    class Ayam : Creatures
    {
        public float matingChance
        {
            get { return 1; }
        }
    }
    class Bixam : Creatures
    {
        public float matingChance
        {
            get { return 1 / 3; }
        }
    }

}

