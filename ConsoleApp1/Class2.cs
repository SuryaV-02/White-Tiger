using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace ConsoleApp1
{
    class GPU
    {
        public GPU()
        {
            Console.WriteLine("Init GPU..");
        }

        public GPU(int version) {
        
        public GPU(string name)
        {
            Console.WriteLine("Creating "  + name + " GPU..");
        }
        public void run()
        {
            for(int i = 0; i < 5; ++i)
            {
                Console.WriteLine("Running " + i);
                Thread.Sleep(1000);
            }
        }

        public void compute()
        {
            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("Computing " + i);
                Thread.Sleep(1000);
            }
        }
    }


    class APU : GPU
    {

        public APU(string name) : base(name)
        {

        } 

        public APU(int version) : base(version)
        {

        }
        public void run()
        {
            base.run();
            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("APU throttling " + i);
                Thread.Sleep(1000);
            }
        }

        

        
        static void Main(string[] args)
        {
            APU nvdia = new APU("nvdia");
            nvdia.compute();
        }
    }

}
