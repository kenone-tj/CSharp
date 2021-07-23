using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEx401
{
    abstract class Bird
    {
        private string name = "";
        public Bird(string name)
        {
            this.name = name;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        //抽象メソッド
        public abstract void sing();
    }
}
