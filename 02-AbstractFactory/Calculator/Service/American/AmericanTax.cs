using System;

namespace AbstractFactory.Calculator.Service.American
{
    public class AmericanTax : ITax
    {
        public void Calculate()
        {
            Console.WriteLine("Calculate American tax...");
        }
    }
}
