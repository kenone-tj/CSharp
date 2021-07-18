using System;

namespace SampleEx101
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person(); // 引数なしのコンストラクタ
            p2 = new Person("山田太郎", 18); // 引数ありのコンストラクタ
            p1.Name = "山田花子";
            p1.Age = 19;
            p1.ShowAgeAndName();
            p2.ShowAgeAndName();
        }
    }
}
