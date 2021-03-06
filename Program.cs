﻿using System;
using System.Reflection;

namespace ElevationMaster
{
    public class EleMaster
    {
        public EleMaster()
        {
            // Program();

            //Student a = new Student(10, 90);
            //Student b = new Student(11, 100);
            //Student c = a + b;
            //int d = a;
            //c.Display();
            //Console.WriteLine("Implicit conversion int {0}", d);
            //12 
        }
        static void Main(string[] args)
        {
            //new EleMaster();
            //Program();
            //var s = new Sentence(null);
            //Console.WriteLine($"The first character is {s.GetFirstCharacter()}");

            Animals a = new ElevationMaster.Animals();
            Pets b = new Pets();
            Animals c = new Pets();
            int abc = (int)3.15;
            // Pets d = new Animals();

            Type d = Type.GetType("System Empty");
            MemberInfo[] memberArray = d.GetMembers();
            Console.WriteLine("There are {0} members in {1}", memberArray.Length, d.FullName);
            //foreach (var member in memberArray)
            //{
            //    Console.WriteLine("Member {0} declared by (1)", member.Name, member.DeclaringType);
            //}

            a.M1();
            a.M2();
            b.M1();
            b.M2();
            c.M1();
            //Console.WriteLine("abc = ",abc);
            c.M2();

            ///<summary
            ///Polymophism practice
            ///</summary
            ///

            //System.Collections.Generic.List<Shape> shapes = new System.Collections.Generic.List<Shape>();
            //shapes.Add(new Rectangle());
            //shapes.Add(new Triangle());
            //shapes.Add(new Circle());

            //foreach (Shape s in shapes)
            //{
            //    s.Draw();
            //}
            //Console.ReadKey();



            ///<summary>
            ///Operator overloading programming practice from MSDN
            ///https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/operator
            /// </summary>

            //Student a = new Student(10, 90);
            //Student b = new Student(11, 100);
            //Student c = a + b;
            //int d = a;
            //c.Display();
            //Console.WriteLine("Implicit conversion int {0}", d);

            ///<summary>
            /// Static constructor and static readonly field programming practice from MSDN
            /// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-constructors
            /// </summary>

            //Bus bus1 = new Bus(71);
            //Bus bus2 = new Bus(72);
            //bus1.Drive();
            //System.Threading.Thread.Sleep(25);
            //bus2.Drive();
            //Console.ReadKey();

        }

        public static void Program()
        {

            try
            {
                bool hasNegative = true;
                int ele1 = 0;
                int ele2 = 0;
                int Num1 = 0;
                int Num2 = 0;
                int count = 0;
                int maxNum = 0;
                int minNum = 0;
                int temp = 0;

                Console.WriteLine("Input a integer: ");
                Num1 = int.Parse(Console.ReadLine());
                minNum = Num1;
                if (Num1 < 0)
                {
                    hasNegative = false;
                }

                if (hasNegative)
                {
                    Console.WriteLine("Input a integer: ");
                    Num2 = int.Parse(Console.ReadLine());
                    maxNum = Num2;
                    temp = Num2;

                    if (Num2 >= 0)
                    {
                        ele1 = Math.Abs(Num1 - Num2);
                        Num1 = Num2;
                        count = 1;
                    }
                    else
                    {
                        hasNegative = false;
                    }
                }

                while (hasNegative)
                {

                    Console.WriteLine("Input a integer: ");
                    Num2 = int.Parse(Console.ReadLine());
                    //temp = Num2;
                    // maxNum = Num2;
                    if (Num2 > 0)
                    {
                        // minNum = maxNum;
                        ele2 = Math.Abs(Num2 - Num1);

                        if (ele2 > ele1)
                        {
                            ele1 = ele2;
                            maxNum = Num2;
                            minNum = temp;
                        }
                    }
                    else
                    {
                        hasNegative = false;
                    }



                }
                if (count > 0)
                {
                    Console.WriteLine("OK done!");
                    Console.WriteLine("The steepest gradient is {0}, which is between elevations {1} and {2}", ele1, minNum, maxNum);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("You didn't provide enough data!");
                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Woops! Something wrong!");
                Console.ReadKey();
            }
        }
    }
}
