using System;

namespace AbstractFactory.Calculator.Service.Chinese
{
    public class ChineseBonus : IBonus
    {
        public void Calculate()
        {
            Console.WriteLine("Calculate Chinese bonus...");
        }
    }
}
