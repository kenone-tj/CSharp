using System;

namespace SampleEx501
{
    class Program
    {
        static void Main(string[] args)
        {
            CellPhone cp = new CellPhone("hose@email.com", "090-1234-5678");
            // 携帯電話クラスで、電話とメールを送る
            cp.Call("011-123-456");
            cp.Mail("fuga@email.com");
            // 電話インターフェースでインスタンスにアクセス
            IPhone phone = (IPhone)cp; // cpをIPhoneでキャストする
            phone.Call("011-987-654"); // 電話をかける
            // 電話インターフェースでインスタンスにアクセス
            IEmail mail = (IEmail)cp; // cpをIEmailでキャストする
            mail.Mail("bar@email.com"); // メールを出す
        }
    }
}
