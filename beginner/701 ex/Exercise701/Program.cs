using System;

namespace Exercise701
{
    class Program
    {
        static void Main(string[] args)
        {
            Vecror2D v1 = new Vecror2D() ;
            v1.X = 1.0; v1.Y = 1.0;
            Vecror2D v2 = new Vecror2D();
            v2.X = 1.0; v2.Y = -1.0;
            v1.Add(v2);
            Console.WriteLine(v1.X + " " + v1.Y);
            v1.Sub(v2);
            Console.WriteLine(v1.X + " " + v1.Y);
            v1.Mul(v2);
            Console.WriteLine(v1.X + " " + v1.Y);
            Console.WriteLine(v1.DotProduct(v2));

        }
    }
}
