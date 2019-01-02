using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMMFight
{
    static class GlobalData
    {
        public static List<GlobalType.AttributesCSV> AttributesCSVs = new List<GlobalType.AttributesCSV>();
        public static List<GlobalType.GetFightCSV> GetFightCSVs = new List<GlobalType.GetFightCSV>();
        /// <summary>
        /// 对象池内有的对象
        /// </summary>
        public static List<Attributes> Attributes = new List<Attributes>();
        public static int campNum = 2;
        public const string presetPlayer1 = @"C:\Users\mash\Desktop\DMM战斗模拟器\模拟\DMMFight\DMMFight\Tabels\PresetPlayer1.dat";
        public const string presetPlayer2 = @"C:\Users\mash\Desktop\DMM战斗模拟器\模拟\DMMFight\DMMFight\Tabels\PresetPlayer2.dat";
        /// <summary>
        /// 版本等级上限
        /// </summary>
        public const int levelMax = 1000;
        /// <summary>
        /// 暴击因子
        /// </summary>
        public const int critFactor = 40000;
        /// <summary>
        /// 闪避因子
        /// </summary>
        public const int dodgyFactor = 10000;
        /// <summary>
        /// PVP保底系数
        /// </summary>
        public const float protectRadioPvp = 0.1f;
        /// <summary>
        /// PVE保底系数
        /// </summary>
        public const float protectRadioPve = 0.5f;
    }
}
