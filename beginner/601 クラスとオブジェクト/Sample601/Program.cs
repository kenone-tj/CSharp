using System;

namespace Sample601
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1;
            Person p2;
            p1 = new Person(); //1つ目のパーソンインスタンスを作成
            p2 = new Person(); //2つ目のパーソンインスタンスを作成
            p1.name = "山田太郎";　//メソッド　フィールドにnameを代入
            p1.age = 19;　//メソッド　フィールドにnameを代入
            p1.ShowAgeAndName(); //メソッド　インスタンスのnameとageを表示
            p2.SetAgeAndName("山田花子", 18);　//メソッド　フィールドにnameとageを代入
            p2.ShowAgeAndName(); //メソッド　インスタンスのnameとageを表示

        }
    }
}
