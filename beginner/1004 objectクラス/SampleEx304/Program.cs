using System;

namespace SampleEx304
{
    class Program
    {
        public void Foo()
        {
            Console.WriteLine("Foo");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.ToString()); // ToString:objectクラス 暗黙の内にobjectクラスを継承している
        }
    }
}
