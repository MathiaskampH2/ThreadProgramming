using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadProgramming
{
    class Program
    {
        static char ch = '*';
        static void Main(string[] args)
        {
            // create printer thread
            Thread printer = new Thread(ThreadPrinter);
           
            // start printer thread
            printer.Start();

            Thread reader = new Thread(ThreadReader);
            reader.Start();


        }

        // ThreadPrinter method that prints the char ch.
        static void ThreadPrinter()
        {
            while (true)
            {
                Console.Write(ch);
                Thread.Sleep(100);
            }
        }

        // threadReader method that writes to char ch.
        static void ThreadReader()
        {
            while (true) 
            {
                ch = Console.ReadKey().KeyChar;
            }
        }
    }
}