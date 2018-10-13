using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.LazyInititalization
{
    class Class
    {
        Lazy<Class> lazyclass = new Lazy<Class>();

        internal Lazy<Class> Lazyclass { get => lazyclass; set => lazyclass = value; } // .NET 4.0 also in .NET core.

        private string _classType;
        private static Dictionary<string, Class> _classDictionary = new Dictionary<string, Class>();

        private Class(string classType)
        {
            _classType = classType;
        }

        public static Class GetClass(string classType)
        {
            Class nonsystemName;

            if (!_classDictionary.TryGetValue(classType, out nonsystemName))
            {
                nonsystemName = new Class(classType);

                _classDictionary.Add(classType, nonsystemName);
            }
            return nonsystemName;
        }

        public static void GetAll()
        {
            if (_classDictionary.Count > 0)
            {
                Console.WriteLine("Count of instantiation = {0}", _classDictionary.Count);

                foreach (KeyValuePair<string, Class> keyValuePair in _classDictionary)
                {
                    Console.WriteLine(keyValuePair.Key);
                }

                Console.WriteLine();
            }
        }

        public Class()
        {
        }
    }
}
