using System;

namespace Exercise801
{
    class Program
    {
        public static void Show(string name, Vecror2D v)
        {
            Console.WriteLine(name +" " + v.X + " " + v.Y);
        }
        static void Main(string[] args)
        {
            Vecror2D v1 = new Vecror2D(1.0, 1.0);
            // v1.X = 1.0; v1.Y = 1.0;
            Vecror2D w = new Vecror2D(1.0, -1.0);
            Vecror2D v2 = new Vecror2D(w);
            // v2.X = 1.0; v2.Y = -1.0;
            v1.Add(v2);
            // Console.WriteLine(v1.X + " " + v1.Y);
            Program.Show("Add", v1);
            v1.Sub(v2);
            // Console.WriteLine(v1.X + " " + v1.Y);
            Program.Show("Sub", v1);
            v1.Mul(v2);
            // Console.WriteLine(v1.X + " " + v1.Y);
            Program.Show("Mul", v1);

            Console.WriteLine(v1.DotProduct(v2));

        }
    }
}
