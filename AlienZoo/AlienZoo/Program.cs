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
        /// <summary>
        ///These things should be initiated in constructor
        ///Here are only for declarition
        /// 
        ///"bool isSimsOn = true;"
        ///"int days = 0;"
        ///"Creatures[] Creature = new Creatures[15];"
        /// </summary>
        public AlienBreedingSims()
        {
            
        }
        public static void Sims() ///This needs to be non-static
        {
            /// bool isSimsOn = true;
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
                    ///<summary>
                    ///Randomly generize one of two types of new creature
                    ///Once the creature being given, it'll be put into class array
                    ///</summary>
                    ///
                    Random rand = new Random();
                    if (rand.Next(1, 101) > 50)
                    {
                        Ayam freshman = new Ayam();
                        Creature[index] = freshman;
                        Creature[index].IsAllowMate = true;
                    }
                    else
                    {
                        Bixam freshman = new Bixam();
                        Creature[index] = freshman;
                        Creature[index].IsAllowMate = true;
                    }
                    // Console.WriteLine("Creature's being generized");
                    var typeb = Creature[index].GetType();
                    Console.WriteLine("Creature[{0}]: {1} is being generized, its type is {1}", index, Creature[index].ToString(), typeb.ToString());

                    ///<summary>
                    ///Traversal all given creatures to see which one can be mated to
                    /// </summary>

                    if (index > 0)
                    {
                        for (int i = 0; i < index; i++)
                        {
                            var typea = Creature[i].GetType();
                            if (Creature[i].IsAllowMate == true && typea == Creature[index].GetType())//   typea.Equals(Creature[index])
                            {
                                Console.WriteLine("Mating ongoing!     fullname is {0}", typea.Name);
                                Creature[index].IsAllowMate = false;
                                Creature[i].IsAllowMate = false;
                                if (typea.Name == nameof(Ayam))
                                {
                                    index++;
                                    Ayam newborn = new Ayam();
                                    Random rand1 = new Random();
                                    if (rand1.Next(1, 101) < newborn.matingChance)
                                    {
                                        Creature[index] = newborn;
                                        Console.WriteLine("mating succeeded!The chances is {0} out of {1}", rand1.ToString(), newborn.matingChance);

                                    }
                                    else Console.WriteLine("matting failed!");
                                    Creature[index].IsAllowMate = true;
                                    Console.WriteLine("Mating Index = {0}", index);
                                }
                                else
                                {
                                    index++;
                                    Bixam newborn = new Bixam();
                                    Random rand1 = new Random();
                                    if (rand1.Next(1, 101) < newborn.matingChance)
                                    {
                                        Creature[index] = newborn;
                                        Console.WriteLine("mating succeeded! The chances is {0} out of {1}", rand1.ToString(), newborn.matingChance);
                                    }
                                    else Console.WriteLine("matting failed!");
                                    Creature[index].IsAllowMate = true;
                                    Console.WriteLine("Mating Index = {0}", index);
                                }
                                //typea newborn = new typea();

                                // Creature[i+1
                            }
                        }
                    }
                    index++;
                    days--;
                    Console.WriteLine("Newday Index = {0}", index);
                    Console.WriteLine("Current Simulation Days: {0}", 15 - days);
                    if (index == 14 || days == 0)
                    {
                        break;

                    }
                    Console.ReadKey();
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
        public int matingChance
        {
            get { return 100; }
        }
    }
    class Bixam : Creatures
    {
        public int matingChance
        {
            get { return 30; }
        }
    }

}

