// 创建人       吴剑超
// 创建时间 2017-08-09 0:21
namespace Singleton
{
    /// <summary>
    /// 延迟加载支持
    /// 使用内部类初始化，可以调用非默认构造函数或执行其他步骤。
    /// </summary>
    public sealed class SingletonNested
    {
        private int count = 0;

        SingletonNested()
        {
        }

        SingletonNested(int count)
        {
            this.count = count;
        }

        public static SingletonStatic Instance => Nested.instance; // 调用的时候才实例化，实现了延迟加载

        private class Nested
        {
            static Nested()
            {
                //
            }

            internal static readonly SingletonStatic instance = new SingletonStatic();
        }
    }
    
}