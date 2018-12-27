using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMMFight
{
    /// <summary>
    /// 全局属性类
    /// </summary>
    class GlobalAttributes
    {
        /// <summary>
        /// 闪避因子
        /// </summary>
        public static int DodgyFactor { get; set; } = 10000;
        /// <summary>
        /// 等级上限
        /// </summary>
        public static int LevelMax { get; set; } = 1000;
        /// <summary>
        /// 初始攻速
        /// </summary>
        public static int SpeedStart { get; set; } = 1000;
        /// <summary>
        /// PVP保底系数
        /// </summary>
        public static float ProtectRadioPvp { get; set; } = 0.1f;
        /// <summary>
        /// PVE保底系数
        /// </summary>
        public static float ProtectRadioPve { get; set; } = 0.5f;
        /// <summary>
        /// 暴击因子
        /// </summary>
        public static int CritFactor { get; set; } = 40000;
    }
}
