using System;
using System.Collections.Generic;
using System.Text;

namespace Sample601
{
    class Person
    {
        // 名前(フィールド)の定義と初期化
        public string name = "";
        // 年齢(フィールド)の定義と初期化
        public int age = 0;
        // 情報の表示(メソッド)
        public void ShowAgeAndName() //voidは戻り値の型 処理結果を返さない
        {
            Console.WriteLine ("名前：" + name + " 年齢：" + age);
        }
        // 情報の設定
        public void SetAgeAndName(string name, int age)　//引数を設定
        {
            this.name = name; //クラスのフィールドにはthis 
            this.age = age;
        }
    }
}
