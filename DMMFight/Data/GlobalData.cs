using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMMFight
{
    class GlobalData
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
        /// 普通攻击
        /// </summary>
        public static Fight.SkillInfo CommanHit = new Fight.SkillInfo
        {
            Name = "普通攻击",
            FixDamage = 120,
            Ratio = 18000f,
            CoolingOff = 0.25f,
            FixDamageAdd = 0,
            RatioAdd = 0,
            Duration = 1.5f,
            IsCoolOff = false
        };
        /// <summary>
        /// 疾风术
        /// </summary>
        public static Fight.SkillInfo Jifengshu = new Fight.SkillInfo
        {
            Name = "疾风术",
            FixDamage = 25,
            Ratio = 12000f,
            CoolingOff = 5f,
            FixDamageAdd = 0,
            RatioAdd = 0,
            Duration = 1f,
            IsCoolOff = false
        };
        /// <summary>
        /// 舞刀术
        /// </summary>
        public static Fight.SkillInfo Wudaoshu = new Fight.SkillInfo
        {
            Name = "舞刀术",
            FixDamage = 60,
            Ratio = 16000f,
            CoolingOff = 8f,
            FixDamageAdd = 0,
            RatioAdd = 0,
            Duration = 1.5f,
            IsCoolOff = false
        };
        /// <summary>
        /// 御气术
        /// </summary>
        public static Fight.SkillInfo Yuqishu = new Fight.SkillInfo
        {
            Name = "御气术",
            FixDamage = 120,
            Ratio = 45000f,
            CoolingOff = 15f,
            FixDamageAdd = 0,
            RatioAdd = 0,
            Duration = 2f,
            IsCoolOff = false
        };
        /// <summary>
        /// 轮式刀法
        /// </summary>
        public static Fight.SkillInfo Lunshidaofa = new Fight.SkillInfo
        {
            Name = "轮式刀法",
            FixDamage = 600,
            Ratio = 90000f,
            CoolingOff = 25f,
            FixDamageAdd = 0,
            RatioAdd = 0,
            Duration = 4f,
            IsCoolOff = false
        };
    }
}
