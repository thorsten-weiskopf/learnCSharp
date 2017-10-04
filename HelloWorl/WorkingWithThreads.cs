using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorl
{
    class WorkingWithThreads
    {

        static Thread thread2 = new Thread(run); //same syntax like delegate

        public static void Play()
        {
            thread2.Start();
            for (int i =0; i <10; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("Hello from Thread 1 !");
            }

            Console.ReadKey();

            thread2.Join();//Marks when thread2 finished its work

        }


        private static void run()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("Hello from Thread 2 !");
            }
        }

    }
}
