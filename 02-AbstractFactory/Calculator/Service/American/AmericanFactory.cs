namespace AbstractFactory.Calculator.Service.American
{    
    public class AmericanFactory : AbstractFactory
    {
        public override IBonus CreateBonus()
        {
            return new AmericanBonus();
        }

        public override ITax CreateTax()
        {
            return new AmericanTax();
        }
    }
}

