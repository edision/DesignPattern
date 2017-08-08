// 创建人       吴剑超
// 创建时间 2017-08-09 0:12
namespace Singleton
{
    /// <summary>
    /// 静态初始化
    /// <para>
    ///     大多数情况下是首选的单件模式实现方式，比如，配置文件初始化。由.Net公共语言运行库管理创建。sealed标记为不可派生，防止继承实例化。
    /// </para>
    /// <para>
    ///     缺点：没办法使用在实例化之前使用非默认构造函数或执行其他任务，无法延迟实例化。
    /// </para>
    /// </summary>
    public sealed class SingletonStatic
    {
        static SingletonStatic()
        {
        }

        public static SingletonStatic Instance { get; } = new SingletonStatic();
        // 等价于
        //static readonly SingletonStatic instance = new SingletonStatic();

        //public static SingletonStatic Instance
        //{
        //    get { return instance; }
        //}
    }
}