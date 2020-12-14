using System;
using System.Diagnostics.PerformanceData;
using System.Security.Cryptography;
using System.Threading;

namespace ThreadProgramming
{
    #region Øvelse 0

    /// <summary>
    /// class WorkThread has method to print out something to the console.
    /// </summary>
    public class WorkThread
    {
        public void WorkThreadFunction()
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Simple thread");
            //}

            Console.WriteLine($"first thread called, name : {Thread.CurrentThread.Name}");
        }

        public void WorkThreadTwo()
        {
            Console.WriteLine($"secound thread called, name :{Thread.CurrentThread.Name}");
        }
        #endregion

    }
}