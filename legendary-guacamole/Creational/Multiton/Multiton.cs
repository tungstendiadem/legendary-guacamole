using System;
using System.Collections.Generic;

namespace Creational.Multiton
{
    public class Multiton
    {
        private Multiton(int num)
        {
            number = num;
        }

        private static List<Multiton> multitons = new List<Multiton>();

        public static object multiton { get; private set; }

        private static int number;

        public static object GetMultiton(int num)
    {
        if (!multitons.Exists(multiton => number==num))
        {
                object multiton = new object();
        }
            return multiton;
        }
    }
}
