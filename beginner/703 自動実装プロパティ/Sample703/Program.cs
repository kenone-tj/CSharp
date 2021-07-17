using System;

namespace Sample703
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            //　名前と年齢を設定
            p.SetAgeAndName("山田太郎", 18);
            //　年齢の変更
            p.Age = 32;
            //　名前の変更(できない)
            // p.Name = "山田花子";
            Console.WriteLine("名前：" + p.Name + " 年齢：" + p.Age);
        }
    }
}
