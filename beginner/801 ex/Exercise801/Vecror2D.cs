using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise801
{
    class Vecror2D
    {
        // 引数なしコンストラクタ
        public Vecror2D()
        {
            Console.WriteLine("引数なしコンストラクタ");
        }
        // 引数ありコンストラクタ1
        public Vecror2D(double x,double y)
        {
            Console.WriteLine("引数ありコンストラクタ1");
            X = x; Y = y;
        }
        // 引数ありコンストラクタ2
        public Vecror2D(Vecror2D v)
        {
            Console.WriteLine("引数ありコンストラクタ2");
            X = v.X ; Y = v.Y ;
        }

        // 自動プロパティ X プロパティは先頭大文字
        public double X 
        {
            set;  get;
        }
        // 自動プロパティY プロパティは先頭大文字
        public double Y
        {
            set;  get;
        }
        // メソッド 足し算
        public void Add(Vecror2D v) // 引数をクラスで宣言
        {
            X += v.X;
            Y += v.Y;
        }
        // メソッド 引き算
        public void Sub(Vecror2D v)
        {
            X -= v.X;
            Y -= v.Y;
        }
        // メソッド 足し算
        public void Mul(Vecror2D v)
        {
            X *= v.X;
            Y *= v.Y;
        }

        public  double DotProduct(Vecror2D v)
        {
            return  X * v.X + Y * v.Y;
        }

    }
}
