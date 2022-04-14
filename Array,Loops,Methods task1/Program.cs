using System;

namespace Array_Loops_Methods_task1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Soz daxil edin");
            string word1 = Console.ReadLine();
            Console.WriteLine("Soz daxil edin");
            string word2 = Console.ReadLine();
            Console.WriteLine("Soz daxil edin");
            string word3 = Console.ReadLine();
            string[] words = { word1, word2, word3 };
            int i = 0;
            foreach (string word in words)
            {
                if (words[i].Length > 5)
                {
                    Console.WriteLine("Uzunlugu 5-den boyuk olan sozler");
                    Console.WriteLine(words[i]);
                }
                else { };
                i++;
            }
        }

        }

    }
