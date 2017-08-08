// 创建人       吴剑超
// 创建时间 2017-08-06 18:47

#region using

using System;
using System.Text;
using System.Threading.Tasks;
using Singleton.SigletonCounter;

#endregion

namespace Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;// .Net Core的BUG，暂时只能手动设置下。

            CounterMultiThread cmt = new CounterMultiThread();
            cmt.Start();
            
            Console.Read();
        }
    }
}