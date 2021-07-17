using System;
using System.Collections.Generic;
using System.Text;

namespace Sample702
{
    class Access
    {
        // 読み込み専用のデータ
        private int data1 = 5;
        // 書き込み専用のデータ
        private int data2 = 0;
        // 値の表示
        public void ShowData()
        {
            Console.WriteLine("data1 = {0} data2 = {1}", data1, data2);
        }
        // data1のプロパティ(読み込みオンリー)
        public int Data1
        {
            get { return data1; }
        }
        // data2のプロパティ(書き込みオンリー)
        public int Data2
        {
            set { data2 = value; }
        }

    }
}
