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
    }
}
