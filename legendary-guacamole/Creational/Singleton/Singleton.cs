using System;

namespace Creational.Singleton
{
    public class Singleton
    {
        private Singleton()
        {
        }

        private static Singleton singleton = null;

        public static Singleton Singletonian { get => Singletonian; set => Singletonian = value; }

        public static Singleton Singletonist { get; set; } = null;
   

    public static Singleton GetSingleton()
    {
        if (singleton == null)
        {
            var singleton = new Singleton();
          
        }
            return singleton;
        }
    }
}
