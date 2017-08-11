using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = Calculator.Service.AbstractFactory.GetInstance();

            var tax = factory.CreateTax();
            tax.Calculate();

            var bonus = factory.CreateBonus();
            bonus.Calculate();

            Console.Read();
        }
    }
}
