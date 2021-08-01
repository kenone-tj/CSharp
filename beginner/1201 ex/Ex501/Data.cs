using System;
using System.Collections.Generic;
using System.Text;

namespace Ex501
{
    class Data : IWriteData, IReadData
    {
        private int num = 0; // データ
        public void Write(int num)
        {
            Console.WriteLine("データの保存");
            this.num = num;
        }
        public int Read()
        {
            Console.WriteLine("データの読み出し");
            return num;
        }
    }
}
