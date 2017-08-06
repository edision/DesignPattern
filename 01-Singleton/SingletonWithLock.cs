using System;

namespace Singleton
{
  class SingletonWithLock
  {
    static SingletonWithLock instance = null;
    static readonly object padLock = new object();

    SingletonWithLock()
    {
      Console.WriteLine("SingletonWithLock created!");
    }

    public static SingletonWithLock Instance
    {
      get
      {
        if (instance == null)
        {
          lock (padLock)
          {
            if (instance == null)
            {
              instance = new SingletonWithLock();
            }
          }
        }
        return instance;
      }
    }
  }
}
