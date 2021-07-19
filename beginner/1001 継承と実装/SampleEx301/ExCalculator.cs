using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEx301
{
    class ExCalculator : Calculator  // 継承　Calculatorクラスをいじれないとき、クラスを受け継ぐ　
    {
        //　掛け算
        public void mul()
        {
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
        }
        // 割り算
        public void div()
        {
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
        }
    }
}
