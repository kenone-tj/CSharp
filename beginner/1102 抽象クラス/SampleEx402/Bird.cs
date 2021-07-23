using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEx402
{
    abstract class Bird //抽象クラス インスタンスは作れない
    {
        // 名前フィールド
        private string name;
        // 引数付コンストラクタ
        public Bird(string name) 
        {
            this.name = name;
        }
        //名前を取得
        public string Name
        {
            get { return name; }
        }
        // 鳴く (抽象メソッド)
        public abstract void Sing(); // abstract 実装がない overrideで実行
    }

}
