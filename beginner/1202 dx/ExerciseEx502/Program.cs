using System;

namespace ExerciseEx502
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("num1 * num2 の結果を計算します");
            Console.WriteLine("num1を入力してください");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("num2を入力してください");
            double num2 = double.Parse(Console.ReadLine());
            Mul1 m = new Mul1();
            //Mul2 m = new Mul2();
            Console.WriteLine("結果：" + m.Calc(num1, num2));
        }
    }
}
