using System;

namespace SampleEx401
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird[] b = new Bird[3];
            b[0] = new Crow();
            b[1] = new Sparrow();
            b[2] = new Chiken();
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i].Name + ":");
                b[i].sing();
            }
        }
    }
}
