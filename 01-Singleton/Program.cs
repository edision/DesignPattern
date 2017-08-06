using System;
using System.Threading.Tasks;

namespace Singleton
{
  class Program
  {
    static void Main(string[] args)
    {
      Task.Run(() => SingletonWithLock.Instance);
      Task.Run(() => SingletonWithLock.Instance);
      Task.Run(() => SingletonWithLock.Instance);
      Task.Run(() => SingletonWithLock.Instance);

      Console.Read();
    }
  }
}
