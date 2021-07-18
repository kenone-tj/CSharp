using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEx101
{
    class Person
    {
        // フィールドname(名前)
        private string name = "";
        // フィールドage(年齢)
        private int age = 0;
        // コンストラクタ(引数なし) クラス名と同じメソッド名
        public Person() : this("名無し", 0)  //コロンでthisは引数ありコンストラクタを実行する
        {
            Console.WriteLine("引数なしコンストラクタ");
        }
        // コンストラクタ(引数あり) クラス名と同じメソッド名
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("引数ありコンストラクタ name:{0} age:{1}",name, age);
        }
        // 情報の表示
        public void ShowAgeAndName()
        {
            Console.WriteLine("名前:{0} 年齢:{1}", name, age);
        }
        // nameのプロパティ
        public string Name
        {
            set; 
            get;  
        }
        // ageのプロパティ
        public int Age
        {
            set; get;
        }
    }
}
