using System;

namespace SampleEx401
{
    class Program
    {
        static void Main(string[] args)
        {
            Crow c = new Crow();
            Sparrow s = new Sparrow();
            // カラスが鳴く
            Console.Write(c.Name + ":");
            c.Sing();
            // スズメが鳴く
            Console.Write(s.Name + ":");
            s.Sing();
        }
    }
}
