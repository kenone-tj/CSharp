using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseEx502
{
    class Mul1
    {
        private double num1 = 0.0, num2 = 0.0;
       
        public double Calc(double num1, double num2)
        {
            double d = 0.0;
            for (int i = 0; i < num2; i++)
            {
                d += num1;
            }
            return d;
        }
    }
}
