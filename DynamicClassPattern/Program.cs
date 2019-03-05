using System;
using System.Dynamic;

namespace DynamicClassPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic dc = new DynamicClass();
            dc.hell = 10;

            Console.WriteLine(dc.hell);

            Action<int> ts = new Action<int>(delegate (int i) {
                Console.WriteLine(i.ToString());
            });

            dc.rs = ts;

            dc.rs(100);


            dynamic ds = new ExpandoObject();
            ds.val = 20;
            Console.WriteLine(ds.val);
            ds.val = "Hello World...";
            Console.WriteLine(ds.val);

            ds.rs = ts;
            ds.rs(100);

            Console.Read();
        }
    }
}
