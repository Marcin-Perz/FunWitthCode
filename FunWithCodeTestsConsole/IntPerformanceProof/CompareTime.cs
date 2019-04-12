using FunWitthCode.IntPerformanceProof;
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
        internal static void GenericTest(string[] args)
        {
            PerformanceMessurmentBasicTypes performanceMessurmentBasicTypes = new PerformanceMessurmentBasicTypes();
            short sizeShort = 250;
            int sizeInt =250;
            long sizeLong = 250;

            Console.WriteLine("by short "+ performanceMessurmentBasicTypes.PopulateCubeWithTypeOfaClassConstructions(sizeShort));
            Console.WriteLine("by int " + performanceMessurmentBasicTypes.PopulateCubeWithTypeOfaClassConstructions(sizeInt));
            Console.WriteLine("by long " + performanceMessurmentBasicTypes.PopulateCubeWithTypeOfaClassConstructions(sizeLong));

        }
        internal static void RunTest(string[] args)
        {


            Console.WriteLine("Pupulanting the cube 150x150x150 with incremental values of a type ");
            long lengthLong = Convert.ToInt64(150);
            int lengthInt = Convert.ToInt32(150);
            short lengthShort = Convert.ToInt16(150);

            long widthLong = Convert.ToInt64(150);
            int widthInt = Convert.ToInt32(150);
            short widthShort = Convert.ToInt16(150);


            long heightLong = Convert.ToInt64(150);
            int heightInt = Convert.ToInt32(150);
            short heightShort = Convert.ToInt16(150);



            FunWitthCode.IntPerformanceProof.LongClass longClass = new FunWitthCode.IntPerformanceProof.LongClass(lengthLong, widthLong, heightLong);
            FunWitthCode.IntPerformanceProof.IntClass intExample = new FunWitthCode.IntPerformanceProof.IntClass(lengthInt, widthInt, heightInt);
            FunWitthCode.IntPerformanceProof.ShortClass shortExample = new FunWitthCode.IntPerformanceProof.ShortClass(lengthShort, widthShort, heightShort);
            
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < 250; i++)
            {
                intExample.PopulateCubeWithTypeOfaClassConstructions();
            }

            stopwatch.Stop();
            TimeSpan intTimeSpan = stopwatch.Elapsed;


            stopwatch.Restart();
            for (short i = 0; i < 250; i++)
            {
                shortExample.PopulateCubeWithTypeOfaClassConstructions();
            }

            stopwatch.Stop();
            TimeSpan shortTimeSpan = stopwatch.Elapsed;

            stopwatch.Restart();
            for (long i = 0; i < 250; i++)
            {
                shortExample.PopulateCubeWithTypeOfaClassConstructions();
            }

            stopwatch.Stop();
            TimeSpan longTimeSpan = stopwatch.Elapsed;

            Console.WriteLine(string.Format("For {0} it took {1} ms", nameof(intTimeSpan), intTimeSpan.Milliseconds  ));
            Console.WriteLine(string.Format("For {0} it took {1} ms", nameof(shortTimeSpan), shortTimeSpan.Milliseconds  ));
            Console.WriteLine(string.Format("For {0} it took {1} ms", nameof(longTimeSpan), longTimeSpan.Milliseconds  ));
            



        }

    }
}
