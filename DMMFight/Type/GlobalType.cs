using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMMFight
{
    /// <summary>
    /// 全局类型类
    /// </summary>
    class GlobalType
    {
        /// <summary>
        /// 单次攻击结果
        /// </summary>
        public enum HitType
        {
            /// <summary>
            /// 闪避
            /// </summary>
            Dodgy = 1,
            /// <summary>
            /// 白字伤害
            /// </summary>
            NormalDamage = 2,
            /// <summary>
            /// 暴击
            /// </summary>
            CritDamage = 3,
            /// <summary>
            /// 精绝一击
            /// </summary>
            GreatDamage = 4,
            /// <summary>
            /// 会心一击
            /// </summary>
            CriticalDamage = 5,
            /// <summary>
            /// 无双一击
            /// </summary>
            LuckyDamage = 6,
            /// <summary>
            /// 致命一击
            /// </summary>
            FatalDamage = 7,
            /// <summary>
            /// 破甲一击
            /// </summary>
            ignoreDamage = 8
        }
        /// <summary>
        /// 击打对象
        /// </summary>
        public enum FightType
        {
            A2B = 1,//A打B
            B2A = 2,//B打A
            AD = -1,//A死亡
            BD = -2 //B死亡
        }
        /// <summary>
        /// 特殊暴击类型
        /// </summary>
        public enum SpecialCrit
        {
            /// <summary>
            /// 没有特殊暴击
            /// </summary>
            NoSpecialCrit = -1,
            /// <summary>
            /// 精绝一击
            /// </summary>
            GreatAtk = 1,
            /// <summary>
            /// 会心一击
            /// </summary>
            CriticalAtk = 2,
            /// <summary>
            /// 无双一击
            /// </summary>
            LuckyAtk = 3,
            /// <summary>
            /// 致命一击
            /// </summary>
            FatalAtk = 4,
        }

        /// <summary>
        /// 属性定义类
        /// </summary>
        public class AttributesCSV
        {
            public int id { get; set; }
            public string key { get; set; }
            public int type { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string count { get; set; }
            public int order { get; set; }
            public string upperLimit { get; set; }
            public string lowerLimit { get; set; }
            public int percent { get; set; }
            public int decimalDigits { get; set; }
            public int group { get; set; }
            public int sort { get; set; }
        }
        /// <summary>
        /// 战斗属性类
        /// </summary>
        public class GetFightCSV
        {
            public int id { get; set; }
            public string key { get; set; }
            public int type { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string count { get; set; }
            public int order { get; set; }
            public string upperLimit { get; set; }
            public string lowerLimit { get; set; }
            public int percent { get; set; }
            public int decimalDigits { get; set; }
            public int group { get; set; }
            public int sort { get; set; }
        }
        /// <summary>
        /// 属性展示类
        /// </summary>
        public class AttributesShow
        {
            public string name;
            public float value;
        }
    }
}
