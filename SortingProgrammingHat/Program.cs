using System;
using System.Collections.Generic;

namespace SortingProgrammingHat
{

    public enum House
    {
        Gryffindor = 1,
        Hufflepuff = 2,
        Ravenclaw = 3,
        Slytherin = 4,

        GRYFFINDOR = 5,
        HUFFLEPUFF = 6,
        RAVENCLAW = 7,
        SLYTHERIN = 8,
    }
    class Program
    {
        public static object House { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to the sorting Ceremony\n");
            Console.WriteLine(" Tell me your favorite programming language and I tell you which house you belong\n");
            Console.WriteLine(" After you've been sorted you may press 0 to exit.");

            List<string> Languages = new List<string>();
            Languages.Add(" 1-JavaScript");
            Languages.Add(" 2-PHP");
            Languages.Add(" 3-SQL");
            Languages.Add(" 4-Python");
            Languages.Add(" 5-C#");
            Languages.Add(" 6-Ruby");
            Languages.Add(" 7-C++");
            Languages.Add(" 8-Java");

            foreach (var prog in Languages)
            {
                Console.WriteLine(prog);
            }

            while (true)
            {
                int Haus = int.Parse(Console.ReadLine());
                Console.WriteLine("\n"+((House)Haus).ToString() +"\n");
  
                if((Haus == 5) || (Haus == 7))
                {
                    Console.WriteLine("However, Hufflepuff would you take you in wholeheartedly.");
                }
                
                if (Haus == 1)
                {
                    Console.WriteLine("Perhaps, Slytherin would you help you to get to the greatness.");
                }

                if ((Haus > 8) || (Haus == 0))
                {
                    Console.WriteLine("You may try again soon");
                    Environment.Exit(0);
                }
            }
        }
    } 
}

