using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCodeTestsConsole
{
    class Program
    {

        /// <summary>
        /// The Strategy pattern is a method by which we can move repeated if/then logic to polymorphism.
        /// In this example, we want to cook some food using a variety of different methods.
        /// In a naive example, we'd need an IF statement for each cooking method.
        /// If we have a lot of cooking methods, we'll also have a lot of IF statements.
        /// But in this example, we can define a Strategy for each cook method and simply set which one we want at runtime.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            // Strategy.StrategyTests.StrategyOnabstractClass(null);

            FunWitthCode.RandomWithRatioShapes randomWithRatioShapes = new FunWitthCode.RandomWithRatioShapes();
            var sasd = randomWithRatioShapes.Randomize();
                StringBuilder sb = new StringBuilder();
            for (int i = 0; i < sasd.GetUpperBound(0); i++)
            {
                StringBuilder sb1 = new StringBuilder();

                for (int k = 0; k < sasd.GetUpperBound(1); k++)
                {
                    sb1.Append(sasd[i, k]);

                }
                sb.AppendLine(sb1.ToString());

            }
            Console.Write(sb.ToString());
            Console.ReadKey(); Console.ReadKey(); Console.ReadKey(); Console.ReadKey();
        }
    }
}
