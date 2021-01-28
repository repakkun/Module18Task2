using System;
using System.Collections.Generic;
using System.Text;
using static Module18Task2.Program;

namespace Module18Task2
{
    class Calculator : ICalculator
    {
        ILogger Logger { get; }
        public Calculator(ILogger logger)
        {
            Logger = logger;
        }     
        public void Addition(int a, int b)
        {
            Logger.Event($"Сумма = {a + b}");
        }
    }
}
