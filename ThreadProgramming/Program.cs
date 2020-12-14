using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Øvelse 3

            //create new object of WorkThread class
            WorkThread wt = new WorkThread();

            //create new Thread and new ThreadStart that class WorkThreadFunction method from WorkThread class.
            Thread tFirst = new Thread(new ThreadStart(wt.CheckOnTemperature));
          
            tFirst.Name = "temperature";
            // starts the Thread
            tFirst.Start();

            
            Thread.Sleep(10000);

            if (tFirst.IsAlive)
            {
                Console.WriteLine("thread tFirst is still running");
            }

            #endregion
        }

    }
}   
