using System;

namespace Sample406
{
    class Program
    {
        static void Main(string[] args)
        {
            // 乱数の初期設定
            Random rnd = new Random(); //ランダムクラスを作成
            Console.WriteLine("6が出たら終了");
            // 無限ループ
            while (true)
            {
                int dise = rnd.Next(1, 7); //1以上7未満の乱数を発生させる
                Console.WriteLine(dise);
                if(dise==6)
                {
                    break; //whileから抜ける switch,while,forでも使用可能
                }
            }
            Console.WriteLine("終了");
        }
    }
}
