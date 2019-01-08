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
        /// 攻击方ID
        /// </summary>
        public int ownID;
        /// <summary>
        /// 受击方ID
        /// </summary>
        public int targetID;
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
        public float damage;
        /// <summary>
        /// 伤害方式(白字/暴击/.....)
        /// </summary>
        public string damageType;
        /// <summary>
        /// 对方的实时血量
        /// </summary>
        public float targetRealtimeHP;

        public string info;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ownPlayerCamp">阵营</param>
        /// <param name="ownPlayerName">名字</param>
        /// <param name="fightType">攻击方式(普攻/技能....)</param>
        /// <param name="targetPlayerCamp">目标阵营</param>
        /// <param name="targetPlayerName">目标名称</param>
        /// <param name="damage">造成伤害</param>
        /// <param name="damageType">伤害方式(白字/暴击/.....)</param>
        public FightInfo(int ownID,int targetID, int ownPlayerCamp,string ownPlayerName,string fightType, int targetPlayerCamp,string targetPlayerName,float damage, Fight.HitType hitType, float targetRealtimeHP)
        {
            this.ownID = ownID;
            this.targetID = targetID;

            switch (ownPlayerCamp)
            {
                case 0:
                    this.ownPlayerCamp = "阵营A";
                    break;
                case 1:
                    this.ownPlayerCamp = "阵营B";
                    break;
                case 2:
                    this.ownPlayerCamp = "阵营C";
                    break;
                case 3:
                    this.ownPlayerCamp = "阵营D";
                    break;
                case 4:
                    this.ownPlayerCamp = "阵营E";
                    break;
                case 5:
                    this.ownPlayerCamp = "阵营F";
                    break;
                default:
                    break;
            }

            this.ownPlayerName = ownPlayerName;
            this.fightType = fightType;

            switch (targetPlayerCamp)
            {
                case 0:
                    this.targetPlayerCamp = "阵营A";
                    break;
                case 1:
                    this.targetPlayerCamp = "阵营B";
                    break;
                case 2:
                    this.targetPlayerCamp = "阵营C";
                    break;
                case 3:
                    this.targetPlayerCamp = "阵营D";
                    break;
                case 4:
                    this.targetPlayerCamp = "阵营E";
                    break;
                case 5:
                    this.targetPlayerCamp = "阵营F";
                    break;
                default:
                    break;
            }
  
            this.targetPlayerName = targetPlayerName;
            this.damage = damage;

            switch (hitType)
            {
                case Fight.HitType.Dodgy:
                    damageType = "没有命中";
                    break;
                case Fight.HitType.NormalDamage:
                    damageType = "白字伤害";
                    break;
                case Fight.HitType.CritDamage:
                    damageType = "暴击伤害";
                    break;
                case Fight.HitType.GreatDamage:
                    damageType = "精绝一击";
                    break;
                case Fight.HitType.CriticalDamage:
                    damageType = "会心一击";
                    break;
                case Fight.HitType.LuckyDamage:
                    damageType = "无双一击";
                    break;
                case Fight.HitType.FatalDamage:
                    damageType = "致命一击";
                    break;
                case Fight.HitType.ignoreDamage:
                    damageType = "破甲一击";
                    break;
                default:
                    break;
            }

            this.targetRealtimeHP = targetRealtimeHP;
        }

        public string GetInfo()
        {
            if (damageType == "没有命中")
            {
                return ownPlayerCamp + "的" + ownPlayerName + "使用" + fightType + "击打" + targetPlayerCamp + "的" + targetPlayerName + ",没有命中";
            }
            else
            {
                return ownPlayerCamp + "的" + ownPlayerName + "使用" + fightType + "击打" + targetPlayerCamp + "的" + targetPlayerName + ",造成了" + damage + "点" + damageType;
            }
            
        }
    }
}
