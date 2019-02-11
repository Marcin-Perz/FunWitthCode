﻿using System;
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

            StrategyTests.StrategyOnabstractClass(null);


        }
    }
}
