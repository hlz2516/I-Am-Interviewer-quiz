using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._2_数据类型
{
    internal class TimeStamp
    {
        public static long DateTimeToStamp(DateTime time)
        {
            return (time.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
        }

        public static DateTime StampToDateTime(long stamp)
        {
            long timeTicks = stamp * 10000000 + 621355968000000000;
            return new DateTime(timeTicks);
        }
    }
}
