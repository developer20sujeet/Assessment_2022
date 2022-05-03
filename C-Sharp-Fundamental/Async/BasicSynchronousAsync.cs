using System;
using System.Collections.Generic;
using System.Text;


using System.Diagnostics;
using System.Threading;

namespace C_Sharp_Fundamental.Async
{
    internal class BasicSynchronousAsync
    {

        public void AsyncDemo()
        {

            var sw = new Stopwatch();
            sw.Start();

            f1();
            f2();
            f3();

            sw.Stop();

            var elapsed = sw.ElapsedMilliseconds;
            Console.WriteLine($"elapsed: {elapsed} ms");
        }

        void f1()
        {
            Console.WriteLine("f1 called");
            Thread.Sleep(4000);
        }

        void f2()
        {
            Console.WriteLine("f2 called");
            Thread.Sleep(7000);
        }

        void f3()
        {
            Console.WriteLine("f3 called");
            Thread.Sleep(2000);
        }
    }
}
