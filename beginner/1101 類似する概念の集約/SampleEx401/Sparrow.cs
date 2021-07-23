using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEx401
{
    class Sparrow
    {
        private string name = "スズメ";
        // スズメが鳴く
        public void Sing()
        {
            Console.WriteLine("チュンチュン");
        }
        public string Name
        {
            get { return name; }
        }

    }
}
