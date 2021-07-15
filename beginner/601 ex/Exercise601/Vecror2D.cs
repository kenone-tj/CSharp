using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise601
{
    class Vecror2D
    {
        // フィールドx
        public double x;
        // フィールドy
        public double y;
        // メソッド 足し算
        public void Add(Vecror2D v) // 引数をクラスで宣言
        {
            this.x += v.x;
            this.y += v.y;
        }
        // メソッド 引き算
        public void Sub(Vecror2D v)
        {
            this.x -= v.x;
            this.y -= v.y;
        }
        // メソッド 足し算
        public void Mul(Vecror2D v)
        {
            this.x *= v.x;
            this.y *= v.y;
        }

        public  double DotProduct(Vecror2D v)
        {
            return  this.x * v.x + this.y * v.y;
        }

    }
}
