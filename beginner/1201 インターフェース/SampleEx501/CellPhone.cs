using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEx501
{
    // 携帯電話クラス　(IPhone,IEmailクラスを実装)
    class CellPhone : IPhone, IEmail
    {
        // メールアドレス
        private string mailAddress;
        // 電話番号
        private string number;
        // コンストラクタ(メールアドレスと電話番号を設定)
        public CellPhone(string mailAddress, string number)
        {
            this.mailAddress = mailAddress;
            this.number = number;
        }
        // 指定したメールアドレスにメールを送る
        public void Mail(string address)
        {
            Console.WriteLine(address + " に " + this.mailAddress + " からメールを送ります");
        }
        // 指定した番号にメールを電話をかける
        public void Call(string number)
        {
            Console.WriteLine(number + " に " + this.number + " から電話を掛けます");
        }

    }
}
