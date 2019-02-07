using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(test1));
            Thread thread2 = new Thread(new ThreadStart(test2));
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.Read();
        }
        static void test1()
        {
            for (int i = 0; i < 60; i++)
            {
                Console.WriteLine("First Thread is: " + i);
            }
            Console.WriteLine("First Thread: Finished");
        }
        static void test2()
        {
            for (int i = 0; i < 60; i++)
            {
                Console.WriteLine("Second Thread is: " + i);
            }
            Console.WriteLine("Second Thread: Finished");
        }

    }

}
