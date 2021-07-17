using System;
using System.Collections.Generic;
using System.Text;

namespace Sample703
{
    class Person
    {
        //情報の設定
        public void SetAgeAndName(string name, int age)
        {
            Name = name;
            Age = age;
        }
        // 情報の表示(メソッド)
        public void ShowAgeAndName() //voidは戻り値の型 処理結果を返さない
        {
            Console.WriteLine ("名前：" + Name + " 年齢：" + Age);
        }
        
        // 情報の設定
        public string Name
        {
            private set; get;
        }
        // 情報の設定
        public int Age
        {
            set; get;
        }
    }
}
