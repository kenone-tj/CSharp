using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise701
{
    class Vecror2D
    {
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
