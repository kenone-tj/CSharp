using System;

namespace Exercise601
{
    class Program
    {
        static void Main(string[] args)
        {
            Vecror2D v1 = new Vecror2D() ;
            v1.x = 1.0; v1.y = 1.0;
            Vecror2D v2 = new Vecror2D();
            v2.x = 1.0; v2.y = -1.0;
            v1.Add(v2);
            Console.WriteLine(v1.x + " " + v1.y);
            v1.Sub(v2);
            Console.WriteLine(v1.x + " " + v1.y);
            v1.Mul(v2);
            Console.WriteLine(v1.x + " " + v1.y);
            Console.WriteLine(v1.DotProduct(v2));

        }
    }
}
