using System;

namespace ExerciseEx202
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("一つ目の数：");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("二つ目の数：");
            int b = int.Parse(Console.ReadLine());
            int max = Numeric.Max(a, b);
            Console.WriteLine("最大値：{0}",max );
        }
    }
}
