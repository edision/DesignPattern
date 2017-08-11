namespace AbstractFactory.Calculator.Service
{    
    using System.Reflection;
    public abstract class AbstractFactory
    {
        public static AbstractFactory GetInstance(){
            var factoryName = ConfigManager.ServiceConfig.ServiceName;
            // 反射读取类型
            var factory = (AbstractFactory)Assembly.Load(new AssemblyName(ConfigManager.ServiceConfig.AssemblyName)).CreateInstance(ConfigManager.ServiceConfig.ServiceName);
            return factory;
        }

        public abstract ITax CreateTax();
        public abstract IBonus CreateBonus();
    }
}
