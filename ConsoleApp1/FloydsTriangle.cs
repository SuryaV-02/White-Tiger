using System;

namespace ConsoleApp1
{
    class FloydsTriangle
    {
        static void Floyd()
        {
            int rows;
            bool b1;
            rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows; ++i)
            {
                if (i % 2 == 0)
                {
                    b1 = false;
                }
                else
                {
                    b1 = true;

                }
                for (int j = 1; j < i + 1; ++j)
                {
                    Console.Write(Convert.ToInt32(b1));
                    b1 = !b1;
                }
                Console.Write("\n");
            }
        }
    }
}
