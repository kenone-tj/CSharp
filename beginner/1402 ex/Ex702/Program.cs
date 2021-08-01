using System;

namespace SampleEx701
{
    // デリゲート メソッドをクラスにする
    delegate void Operation(int a, int b);
    // Calcクラス
    class Calc
    {
        public void sub(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
    }
    // Programクラス
    class Program
    {
        static void Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        static void Mul(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
        static void Div(int a, int b)
        {
            try
            {
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("ゼロでの割り算はできません");
            }
            finally
            {
                Console.WriteLine("終了");
            }
        }

        static void Main(string[] args)
        {
            Calc c = new Calc();
            // デリゲートの設定
            Operation o1 = new Operation(Add); // 引数にメソッド名を指定する
            o1 += new Operation(c.sub);
            o1 += new Operation(Mul);
            o1 += new Operation(Div);
            o1(2,0);

            //Operation o2 = new Operation(c.sub); // 引数にメソッド名を指定する
            //// デリゲートで設定したメソッドの呼び出し
            //o1(2, 1);
            //o2(2, 1);
        }
    }
}
