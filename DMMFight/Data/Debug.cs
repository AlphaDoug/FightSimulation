using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMMFight
{
    /// <summary>
    /// 调试类
    /// </summary>
    class Debug
    {
        /// <summary>
        /// 调试输出一行信息
        /// </summary>
        /// <param name="str">输出的字符串</param>
        public static void LogOut(string str)
        {
            Console.WriteLine(str);
        }
        /// <summary>
        /// 调试输出字符串数组中信息
        /// </summary>
        /// <param name="str">输出的字符串数组</param>
        public static void LogOut(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
        }
        /// <summary>
        /// 调试输出一行数字
        /// </summary>
        /// <param name="i"></param>
        public static void LogOut(int i)
        {
            Console.WriteLine(i.ToString());
        }
        /// <summary>
        /// 调试输出int数组
        /// </summary>
        /// <param name="ia"></param>
        public static void LogOut(int[] ia)
        {
            for (int i = 0; i < ia.Length; i++)
            {
                Console.WriteLine(ia[i].ToString());
            }
        }
        /// <summary>
        /// 调试输出单精度小数
        /// </summary>
        /// <param name="f"></param>
        public static void LogOut(float f)
        {
            Console.WriteLine(f.ToString());
        }
        /// <summary>
        /// 调试输出单精度小数数组
        /// </summary>
        /// <param name="f"></param>
        public static void LogOut(float[] f)
        {
            for (int i = 0; i < f.Length; i++)
            {
                Console.WriteLine(f[i].ToString());
            }
        }
        /// <summary>
        /// 调试输出双精度浮点小数
        /// </summary>
        /// <param name="d"></param>
        public static void LogOut(double d)
        {
            Console.WriteLine(d.ToString());
        }
        /// <summary>
        /// 调试输出双精度小数数组
        /// </summary>
        /// <param name="d"></param>
        public static void LogOut(double[] d)
        {
            for (int i = 0; i < d.Length; i++)
            {
                Console.WriteLine(d[i].ToString());
            }
        }
    }
}
