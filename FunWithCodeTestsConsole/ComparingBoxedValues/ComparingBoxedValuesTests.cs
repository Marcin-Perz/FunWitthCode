using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCodeTestsConsole.ComparingBoxedValues
{
    class ComparingBoxedValuesTests
    {
        internal static void CompareDoubles(string[] args)
        {
  

            Console.WriteLine("Type first double that you want compare with:");
            var input = Console.ReadLine();
            double val1 = Convert.ToDouble(input);
            Console.WriteLine("Type second double that you want compare to:");
            input = Console.ReadLine();
            double val2 = Convert.ToDouble(input);

            FunWitthCode.ComparingBoxedValueTypes.ComapreBoxedValues<double, double> test = new FunWitthCode.ComparingBoxedValueTypes.ComapreBoxedValues<double, double>(val1, val2);
            Console.WriteLine("Classic operator:");
            Console.WriteLine(test.ClassicOperator());
            Console.WriteLine("ReplacmentMethod1 result:");
            Console.WriteLine(test.ReplacmentMethod1());


            Console.ReadKey();
        }
        internal static void CompareStrings(string[] args)
        {


            Console.WriteLine("Type first double that you want compare with:");
            var input = Console.ReadLine();
            string val1 = Convert.ToString(input);
            Console.WriteLine("Type second double that you want compare to:");
            input = Console.ReadLine();
            string val2 = Convert.ToString(input);

            FunWitthCode.ComparingBoxedValueTypes.ComapreBoxedValues<string, string> test = new FunWitthCode.ComparingBoxedValueTypes.ComapreBoxedValues<string, string>(val1, val2);
            Console.WriteLine("Classic operator:");
            Console.WriteLine(test.ClassicOperator());
            Console.WriteLine("ReplacmentMethod1 result:");
            Console.WriteLine(test.ReplacmentMethod1());


            Console.ReadKey();
        }
    }
}
