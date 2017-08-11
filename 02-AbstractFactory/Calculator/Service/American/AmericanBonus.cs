using System;

namespace AbstractFactory.Calculator.Service.American
{
    public class AmericanBonus : IBonus
    {
        public void Calculate()
        {
            Console.WriteLine("Calculate American bonus...");
        }
    }
}
