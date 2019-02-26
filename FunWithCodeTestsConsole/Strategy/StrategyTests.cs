using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCodeTestsConsole.Strategy
{
   static class StrategyTests
    {
        internal static void StrategyOnabstractClass(string[] args)
        {
            FunWitthCode.StrategyPattern.CompositionWithStrategyPatterns Example = new FunWitthCode.StrategyPattern.CompositionWithStrategyPatterns();
            Example.decorationStrategy = null;

            Console.WriteLine("Type string that you want to decorate:");
            var input = Console.ReadLine();

            Console.WriteLine("What cooking strategy would you like to use (1-3)?");
            int inputNumber = int.Parse(Console.ReadKey().KeyChar.ToString());


            switch (inputNumber)
            {
                case 1:
                    Example.decorationStrategy = new FunWitthCode.StrategyPattern.DecorateStrategyExamples.PinkStink();
                    input = Example.decorationStrategy.Decorate(input);
                    break;

                case 2:
                    Example.decorationStrategy = new FunWitthCode.StrategyPattern.DecorateStrategyExamples.ForkInTheEye();
                    input = Example.decorationStrategy.Decorate(input);
                    break;

                case 3:
                    Example.decorationStrategy = new FunWitthCode.StrategyPattern.DecorateStrategyExamples.BlueRibbon();
                    input = Example.decorationStrategy.Decorate(input);
                    break;


            }
            Console.WriteLine();
            Console.WriteLine(input);
            Console.ReadKey();
        }
        internal static void StrategyOnInterface(string[] args)
        {
            FunWitthCode.StrategyPattern.CompositionWithStrategyPatterns Example = new FunWitthCode.StrategyPattern.CompositionWithStrategyPatterns();
            Example.decorationStrategy = null;

            Console.WriteLine("Type string that you want to decorate:");
            var input = Console.ReadLine();

            Console.WriteLine("What cooking strategy would you like to use (1-3)?");
            int inputNumber = int.Parse(Console.ReadKey().KeyChar.ToString());


            switch (inputNumber)
            {
                case 1:
                    Example.decorationStrategy = new FunWitthCode.StrategyPattern.DecorateStrategyExamples.PinkStink();
                    input = Example.decorationStrategy.Decorate(input);
                    break;

                case 2:
                    Example.decorationStrategy = new FunWitthCode.StrategyPattern.DecorateStrategyExamples.ForkInTheEye();
                    input = Example.decorationStrategy.Decorate(input);
                    break;

                case 3:
                    Example.decorationStrategy = new FunWitthCode.StrategyPattern.DecorateStrategyExamples.BlueRibbon();
                    input = Example.decorationStrategy.Decorate(input);
                    break;


            }
            Console.WriteLine();
            Console.WriteLine(input);
            Console.ReadKey();
        }
    }
}
