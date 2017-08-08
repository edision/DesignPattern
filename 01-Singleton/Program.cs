// 创建人       吴剑超
// 创建时间 2017-08-06 18:47

#region using

using System;
using System.Threading.Tasks;

#endregion

namespace Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Task.Run(() => SingletonWithLock.Instance);
            Task.Run(() => SingletonWithLock.Instance);
            Task.Run(() => SingletonWithLock.Instance);
            Task.Run(() => SingletonWithLock.Instance);

            Console.Read();
        }
    }
}