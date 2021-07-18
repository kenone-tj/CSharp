using System;

namespace SampleEx202
{
    class Program
    {
        // staticなフィールド 　同じクラスでそのまま使える
        private static int snum = 100;
        // インスタンスフィールド インスタンスを生成しないと使えない
        public int inum = 200;
        // staticなメソッド
        public static void foo()
        {
            Console.WriteLine("fooメソッド(スタティックメソッド)");
        }
        public static void var()
        {
            Console.WriteLine("varメソッド(インスタンスメソッド)");
        }
        static void Main(string[] args) //Mainはスタティックメソッド
        {
            Program p = new Program();
            Console.WriteLine("pのインスタンスフィールド:inum = {0}", p.inum);
            Console.WriteLine("programのクラスフィールド:inum = {0}", snum); // Program.snumでも良い　同じクラスなので省略できる
            foo(); //Program.foo()でも良い　同じクラスなので省略できる
            var(); //Program.Var()でも良い　同じクラスなので省略できる
        }
    }
}
