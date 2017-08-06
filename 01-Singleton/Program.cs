using System;

namespace Singleton
{
  class Program
  {
    static void Main(string[] args)
    {
      SingletonV1.Instance.Info();
      SingletonV1.Instance.Info();
      SingletonV1.Instance.Info();
      SingletonV1.Instance.Info();

      Console.Read();
    }
  }
}
