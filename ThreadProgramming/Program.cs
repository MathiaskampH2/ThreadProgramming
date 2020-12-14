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
        static void Main(string[] args)
        {
            #region Øvelse 0

            //create new object of WorkThread class
            WorkThread wt = new WorkThread();

            //create new Thread and new ThreadStart that class WorkThreadFunction method from WorkThread class.
            Thread tFirst = new Thread(new ThreadStart(wt.WorkThreadFunction));

            tFirst.Name = "Work thread 1";
            // starts the Thread
            tFirst.Start();
            tFirst.Join();
            Thread tSecound = new Thread(new ThreadStart(wt.WorkThreadTwo));
            tSecound.Name = "Work thread 2";
            tSecound.Start();
            Console.Read();
            #endregion
        }
    }
}
