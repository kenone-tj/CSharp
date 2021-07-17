using System;

namespace Sample701
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1;
            Person p2;
            p1 = new Person(); //1つ目のパーソンインスタンスを作成
            p2 = new Person(); //2つ目のパーソンインスタンスを作成
            p1.Name = "山田太郎";　//メソッド　フィールドにNameを代入
            p1.Age = 19;　//メソッド　フィールドにNameを代入
            p1.ShowAgeAndName(); //メソッド　インスタンスのnameとageを表示
            p2.Name = "山田花子";　//メソッド　フィールドにNameを代入
            p2.Age = 18;　//メソッド　フィールドにnameを代入
            p2.ShowAgeAndName(); //メソッド　インスタンスのNameとageを表示
            // プロパティから名前と年齢を表示
            Console.WriteLine("名前：" + p2.Name + " 年齢：" + p2.Age);
        }
    }
}
