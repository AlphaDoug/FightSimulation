using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMMFight
{
    /// <summary>
    /// 战斗实时信息
    /// </summary>
    class FightInfo
    {
        /// <summary>
        /// 攻击方阵营
        /// </summary>
        public string ownPlayerCamp;
        /// <summary>
        /// 攻击方名称
        /// </summary>
        public string ownPlayerName;
        /// <summary>
        /// 攻击方式(普攻/技能....)
        /// </summary>
        public string fightType;
        /// <summary>
        /// 目标阵营
        /// </summary>
        public string targetPlayerCamp;
        /// <summary>
        /// 目标名称
        /// </summary>
        public string targetPlayerName;
        /// <summary>
        /// 造成伤害
        /// </summary>
        public string damage;
        /// <summary>
        /// 伤害方式(白字/暴击/.....)
        /// </summary>
        public string damageType;

        public string info;

        public FightInfo(string ownPlayerCamp,string ownPlayerName,string fightType,string targetPlayerCamp,string targetPlayerName,string damage,string damageType)
        {
            this.ownPlayerCamp = ownPlayerCamp;
            this.ownPlayerName = ownPlayerName;
            this.fightType = fightType;
            this.targetPlayerCamp = targetPlayerCamp;
            this.targetPlayerName = targetPlayerName;
            this.damage = damage;
            this.damageType = damageType;
        }

        public string GetInfo()
        {
            if (damage == "0")
            {
                return ownPlayerCamp + "的" + ownPlayerName + "使用" + fightType + "击打" + targetPlayerCamp + "的" + targetPlayerName + "没有命中";
            }
            else
            {
                return ownPlayerCamp + "的" + ownPlayerName + "使用" + fightType + "击打" + targetPlayerCamp + "的" + targetPlayerName + "造成了" + damage + "点" + damageType;
            }
            
        }
    }
}
