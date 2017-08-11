using System;

namespace AbstractFactory.Calculator.Service.Chinese
{
    public class ChineseTax : ITax
    {
        public void Calculate()
        {
            Console.WriteLine("Calculate Chinese tax...");
        }
    }
}
