namespace Singleton
{
  using System;
  /// <summary>
  /// 单件模式第一版
  /// <remark>
  /// 不支持多线程，没有线程安全支持
  /// </remark>
  /// </summary>
  public class Singleton
  {
    private static Singleton _Instance;

    private Singleton()
    {
      Console.WriteLine("SingletonV1 created!");
    }

    public static Singleton Instance
    {
      get
      {
        if (_Instance == null) _Instance = new Singleton();
        return _Instance;
      }
    }

    public void Info()
    {
      Console.WriteLine("SingletonV1 info.....");
    }
  }
}
