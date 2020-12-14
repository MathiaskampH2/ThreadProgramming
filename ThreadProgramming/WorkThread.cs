using System;
using System.Diagnostics.PerformanceData;
using System.Security.Cryptography;
using System.Threading;

namespace ThreadProgramming
{
    #region øvelse 1

    /// <summary>
    /// class WorkThread has method to print out something to the console.
    /// </summary>
    public class WorkThread
    {
      
        #region Øvelse 1
        public void WorkThreadPrintFiveTimes()
        {
            for (int i = 0; i < 5; i++)
            {
                // thread.Sleep 1secound 
                Thread.Sleep(1000);
                Console.WriteLine("C#-trådning er nemt!");
            }

        }

        public void WorkThreadPrintFiveTimesTwo()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(" Også med flere tråde...");
            }
        }
        #endregion
    }
#endregion
    }
}
