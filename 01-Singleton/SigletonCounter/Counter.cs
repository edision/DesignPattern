// 创建人       吴剑超
// 创建时间 2017-08-09 0:31
namespace Singleton.SigletonCounter
{
    /// <summary>
    /// 计算器
    /// 功能：提供全局计数
    /// </summary>
    public class Counter
    {
        private static readonly Counter uniCounter = new Counter();
        private Counter()
        {
        }

        private int totalNum = 0;

        public static Counter Instance()
        {
            return uniCounter;
        }

        public void Add()
        {
            totalNum++;
        }

        public int GetTotal()
        {
            return totalNum;
        }
    }
}