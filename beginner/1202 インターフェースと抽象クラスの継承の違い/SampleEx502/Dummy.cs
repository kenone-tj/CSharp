﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEx502
{
    class Dummy : IFunc1, IFunc2
    {
        public void Func1()
        {
            Console.WriteLine("Func1");
        }
        public void Func2()
        {
            Console.WriteLine("Func2");
        }

        public void Func3()
        {
            Console.WriteLine("Func3");
        }

    }
}
