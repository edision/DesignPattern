namespace AbstractFactory.Calculator.Service.Chinese
{
    public class ChineseFactory : AbstractFactory
    {
        public override IBonus CreateBonus()
        {
            return new ChineseBonus();
        }

        public override ITax CreateTax()
        {
            return new ChineseTax();
        }
    }
}
