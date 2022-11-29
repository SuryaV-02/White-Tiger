using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class ThreadingSynchronization
    {
        static void Runner(Object cursor)
        {
            lock (cursor)
            {
                for (int i = 0; i < 5; ++i)
                {
                    Console.WriteLine("~" + Thread.CurrentThread.Name + " --> Reading line" + i);
                    Thread.Sleep(1000);
                }
            }
            
        }

        static void Main2(string[] args)
        {
            Object cursor = new Object();

            Thread Reader1 = new Thread(()=> Runner(cursor));
            Thread Reader2 = new Thread(() => Runner(cursor));

            Reader2.IsBackground = true;

            Reader1.Name = "Gedit";
            Reader2.Name = "Sublime";

            Reader1.Start();
            Reader2.Start();
        }

    }
}
