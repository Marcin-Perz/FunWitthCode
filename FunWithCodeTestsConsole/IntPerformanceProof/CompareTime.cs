using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCodeTestsConsole.IntPerformanceProof
{
    class CompareTime
    {
        internal static void RunTest(string[] args)
        {


            Console.WriteLine("Type length, width, height is 150:");

            int lengthInt = Convert.ToInt32(150);
            short lengthShort = Convert.ToInt16(150);


            int widthInt = Convert.ToInt32(150);
            short widthShort = Convert.ToInt16(150);


            int heightInt = Convert.ToInt32(150);
            short heightShort = Convert.ToInt16(150);




            FunWitthCode.IntPerformanceProof.IntClass intExample = new FunWitthCode.IntPerformanceProof.IntClass(lengthInt, widthInt, heightInt);
            FunWitthCode.IntPerformanceProof.ShortClass shortExample = new FunWitthCode.IntPerformanceProof.ShortClass(lengthShort, widthShort, heightShort);

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < 25; i++)
            {
                intExample.PopulateCubeWithSmallUnitsCubes();
            }

            stopwatch.Stop();
            TimeSpan intTimeSpan = stopwatch.Elapsed;


            stopwatch.Restart();
            for (int i = 0; i < 25; i++)
            {
                shortExample.PopulateCubeWithSmallUnitsCubes();
            }

            stopwatch.Stop();

            TimeSpan shortTimeSpan = stopwatch.Elapsed;



            Console.WriteLine(string.Format("For Ints it took {0} Milliseconds and for shorts it took {1} Milliseconds.", intTimeSpan.TotalMilliseconds, shortTimeSpan.TotalMilliseconds ));




        }

    }
}
