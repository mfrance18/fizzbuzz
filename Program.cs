using System;
using System.Collections.Generic;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)

        {
            List<string> list = new List<string>();



            for (int n = 1; n <= 100; n++)
            {
                if (n % 15 == 0)
                {
                    list.Add("fizzbuzz");
                }
                else if (n % 3 == 0)
                {
                    list.Add("fizz");
                }
                else if (n % 5 == 0)
                {
                    list.Add("buzz");
                }
                else
                {
                    list.Add(n.ToString());
                }
            }

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
