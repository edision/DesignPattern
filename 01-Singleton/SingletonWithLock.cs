// 创建人       吴剑超
// 创建时间 2017-08-06 20:58

#region using

using System;

#endregion

namespace Singleton
{
    /// <summary>
    /// 单件模式
    /// <remarks>
    /// <para>
    /// 通过线程锁，支持并发线程获取实例。为了提高性能，使用了双重判断。
    /// </para>
    /// </remarks>
    /// </summary>
    internal class SingletonWithLock
    {
        private static SingletonWithLock instance = null;
        private static readonly object padLock = new object();

        private SingletonWithLock()
        {
            Console.WriteLine("SingletonWithLock created!");
        }

        public static SingletonWithLock Instance
        {
            get
            {
                if (instance == null) // 外层添加判断，不用每次都lock,提高性能。
                {
                    lock (padLock)
                    {
                        if (instance == null) // 线程内部逻辑
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