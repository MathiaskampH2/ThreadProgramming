using System;
using System.Data.SqlTypes;
using System.Diagnostics.PerformanceData;
using System.Security.Cryptography;
using System.Threading;

namespace ThreadProgramming
{
    #region øvelse 3

    /// <summary>
    /// class WorkThread has method to print out something to the console.
    /// </summary>
    public class WorkThread
    {
        
        // gets randomNumber between -20 and 120

        public int RandomTemperature()
        {
            Random rng = new Random();
            int temperature = 0;
            temperature = rng.Next(-20, 120);

            return temperature;

        }

        // checks if the randomNumber is within 0-100 
        public void CheckOnTemperature()
        {
            
            int counter = 0;

            while (counter < 3)
            {
                int temperature = RandomTemperature();

                if (temperature > 100 || temperature < 0)
                {
                    counter++;
                    Console.WriteLine($"Temperature is not within the range of 0 - 100 degrees: temp:{temperature} alert count : {counter}");

                }

                else
                {
                    Console.WriteLine($"Temperature is fine : {temperature}");
                }

                Thread.Sleep(2000);
            }
        }
        #endregion
    }
}