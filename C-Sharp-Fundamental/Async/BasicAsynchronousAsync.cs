using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_Sharp_Fundamental.Async
{
    internal class BasicAsynchronousAsync
    {

        public async Task AsyncDemo()
        {

            var sw = new Stopwatch();
            sw.Start();

            // Task.WaitAll(f1(), f2(), f3());

           // Task.WhenAll(f1(), f2(), f3());

            sw.Stop();

            var elapsed = sw.ElapsedMilliseconds;
            Console.WriteLine($"elapsed: {elapsed} ms");
        }

        async Task f1()
        {
            await Task.Delay(4000);
            Console.WriteLine("f1 finished");
        }

        async Task f2()
        {
            await Task.Delay(7000);
            Console.WriteLine("f2 finished");
        }

        async Task f3()
        {
            await Task.Delay(2000);
            Console.WriteLine("f3 finished");
        }
    }
}
