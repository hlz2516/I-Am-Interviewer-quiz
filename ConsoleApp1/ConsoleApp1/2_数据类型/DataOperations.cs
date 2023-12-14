using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._2_数据类型
{
    internal class DataOperations
    {
        public static void Swap(ref int a,ref int b)
        {
            int temp = 0;
            temp = a;
            a = b; 
            b = temp;
        }
    }
}
