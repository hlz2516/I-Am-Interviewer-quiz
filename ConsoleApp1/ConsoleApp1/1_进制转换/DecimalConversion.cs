using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1_进制转换
{
    internal class DecimalConversion
    {
        public static byte[] IntToBytes(int n)
        {
            //return BitConverter.GetBytes(n);
            //一个int四字节，所以通过移位+&的方式取到各个位置上的字节
            byte[] bytes = new byte[4];
            bytes[0] = (byte)(n & 0xff);
            bytes[1] = (byte)(n >> 8 & 0xff);
            bytes[2] = (byte)(n >> 16 & 0xff);
            bytes[3] = (byte)(n >> 24 & 0xff);
            return bytes;
        }

        public static int BytesToInt(byte[] bytes)
        {
            //return BitConverter.ToInt32 (bytes, 0);
            //四字节不能直接转int，因此需要将四字节拼接成一个32位的bits再强制转成int
            return bytes[0] | (bytes[1] << 8) | (bytes[2] << 16) | (bytes[3] << 24);
        }
    }
}
