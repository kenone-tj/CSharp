using System;

namespace SampleEx301
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculatorクラスのインスタンス
            Calculator c1 = new Calculator();
            c1.Num1 = 10;
            c1.Num2 = 2;
            c1.add();
            c1.sub();
            //ExCalculatorクラスのインスタンス
            ExCalculator c2 = new ExCalculator();
            c2.Num1 = 10;
            c2.Num2 = 2;
            c2.mul();
            c2.div();
        }
    }
}
