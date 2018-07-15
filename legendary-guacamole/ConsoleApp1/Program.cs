using System;
using InCaseOf;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hello World!");
      
            caseDeterminer x = new caseDeterminer();
            bool c = x.CaseEquivalent("bTard");

            Console.WriteLine(c.ToString());

            bool d = x.CaseEquivalent("b_tard");

            Console.WriteLine(d.ToString());

        }
    }
}
