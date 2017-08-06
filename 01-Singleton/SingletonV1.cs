namespace Singleton
{
    using System;
    /// <summary>
    /// 单件模式第一版
    /// <remark>
    /// 不支持多线程，没有线程安全支持
    /// </remark>
    /// </summary>
    public class SingletonV1
    {
        private static SingletonV1 _Instance;

        private SingletonV1(){
            Console.WriteLine("SingletonV1 created!");
        }

        public static SingletonV1 Instance{
            get {
                if(_Instance == null) _Instance = new SingletonV1();
                return _Instance;
            }
        }

        public void Info() {
            Console.WriteLine("SingletonV1 info.....");
        }
    }
}
