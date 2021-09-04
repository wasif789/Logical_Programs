using System;
using System.Diagnostics;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new stopwatch
            Stopwatch stopWatch = new Stopwatch();
            //Begin Timimg
            stopWatch.Start();
            //do something
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(10);
            }
            //stop timing
            stopWatch.Stop();
            //printing result
            Console.WriteLine("Time Elapsed:{0}", stopWatch.Elapsed);

        }
    }
}
