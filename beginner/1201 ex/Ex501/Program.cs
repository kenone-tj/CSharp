using System;

namespace Ex501
{
    class Program
    {
        static void Main(string[] args)
        {
            Data d = new Data();
            //d.Write(1);
            //int num = d.Read();
            //Console.WriteLine("data = {0}", num);
            IWriteData w = (IWriteData)d;
            w.Write(1);
            IReadData r = (IReadData)d;
            int num = r.Read();
            Console.WriteLine("data = {0}", num);
        }
    }
}
