using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEx401
{
    class Crow
    {
        private string name = "カラス";
        // カラスが鳴く
        public void Sing()
        {
            Console.WriteLine("カーカー");
        }
        public string Name
        {
            get { return name; }
        }
    }
}
