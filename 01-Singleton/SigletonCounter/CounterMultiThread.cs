// 创建人       吴剑超
// 创建时间 2017-08-09 0:37

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton.SigletonCounter
{
    public class CounterMultiThread
    {
        private void DoWork()
        {
            Counter counter = Counter.Instance();

            for (int i = 0; i < 5; i++)
            {
                counter.Add();

                Console.WriteLine($"线程 {Thread.CurrentThread.Name} --> 当前计数： {counter.GetTotal()}\n");
            }
        }

        public void Start()
        {
            Thread.CurrentThread.Name = "Thread 0";

            Thread thread1 = new Thread(DoWork) { Name = "Thread 1" };
            Thread thread2 = new Thread(DoWork) { Name = "Thread 2" };
            Thread thread3 = new Thread(DoWork) { Name = "Thread 3" };
            thread1.Start();
            thread2.Start();
            thread3.Start();

            // 线程0也只执行和其他线程相同的工作
            DoWork();
        }
    }
}