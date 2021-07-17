using System;
using System.Collections.Generic;
using System.Text;

namespace Sample701
{
    class Person
    {
        // 名前(フィールド)の定義と初期化 private:アクセス修飾子 このクラスでしか呼び出せない
        private string name = "";
        // 年齢(フィールド)の定義と初期化
        private int age = 0;
        // 情報の表示(メソッド)
        public void ShowAgeAndName() //voidは戻り値の型 処理結果を返さない
        {
            Console.WriteLine ("名前：" + name + " 年齢：" + age);
        }
        
        // 情報の設定
        public string Name
        {
            set { name = value; } // 外から与えられた値
            get { return name; }
        }
        // 情報の設定
        public int Age
        {
            set { age = value; } // 外から与えられた値
            get { return age; }
        }
    }
}
