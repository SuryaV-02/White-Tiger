using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class LearningThreadBasics
    {
        static void runner()
        {
            for(int i=0; i<10; ++i)
            {
                Console.WriteLine("Hi " + i);
                Thread.Sleep(1000);
                if (i == 2)
                {
                    Thread.CurrentThread.Interrupt();
                    Console.WriteLine("Putting to sleep");
                    Thread.CurrentThread.Resume();
                    Thread.Sleep(2000);
                }
            }
        }

        static void ThreadARunner()
        {
            Console.WriteLine("Runner 1");
            for(int i=0; i<10; ++i)
            {
                Console.WriteLine("Runner A " + i);
                Thread.Sleep(1000);

            }
        }
        static void ThreadBRunner()
        {
            Console.WriteLine("Runner 2");
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine("Runner B " + i);
                Thread.Sleep(1000);
            }
        }

        static void Major(string[] ags)
        {
            // ThreadStart RunnerThreadStart = new ThreadStart(runner);
            //Thread threadRunner = new Thread(RunnerThreadStart);
            //threadRunner.Start();
            ThreadStart tsA = new ThreadStart(ThreadARunner);
            ThreadStart tsB = new ThreadStart(ThreadBRunner);

            Thread t1 = new Thread(tsA);
            Thread t2 = new Thread(tsB);

            t1.Start();
            t1.Join();
            t2.Start();
           


        }
    }
}
