using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DMMFight
{
    /// <summary>
    /// 一个对象的实时战斗类
    /// </summary>
    class Fight
    {
        /// <summary>
        /// 特殊暴击类型
        /// </summary>
        private enum SpecialCrit
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
        /// 单次攻击结果
        /// </summary>
        private enum HitType
        {
            /// <summary>
            /// 结果闪避
            /// </summary>
            Dodgy = 1,
            /// <summary>
            /// 普通伤害
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

        Attributes m_attribute = null;
        int camp = -1;
        System.Timers.Timer t;
        public Fight(Attributes attributes)
        {
            m_attribute = attributes;
            camp = attributes.camp;
        }

        /// <summary>
        /// 开始战斗
        /// </summary>
        public void FightStart()
        {

            t = new System.Timers.Timer(1000);
            t.Elapsed += new System.Timers.ElapsedEventHandler(Fighting);//到达时间的时候执行事件；
            t.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；
            t.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；
        }

        /// <summary>
        /// 停止战斗
        /// </summary>
        public void FightStop()
        {
            if (t != null)
            {
                t.Elapsed -= Fighting;
            }
            


        }
        /// <summary>
        /// 击打一次的过程
        /// </summary>
        /// <param name="own">伤害发起者</param>
        /// <param name="target">被击打者</param>
        /// <returns></returns>
        void Fighting(object source, System.Timers.ElapsedEventArgs e)
        {
            //遍历对象池中所有非己方阵营的对象,对其造成伤害
            for (int i = 0; i < GlobalData.Attributes.Count; i++)
            {
                if (camp != GlobalData.Attributes[i].camp)//非己方阵营,为敌人
                {

                }
            }

        }
        /// <summary>
        /// 一方击打另一方
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        private void A_Hit_B(Attributes A, Attributes B)
        {

        }

        /// <summary>
        /// 检查是否闪避
        /// </summary>
        /// <returns>真为闪避,假为命中</returns>
        bool CheckDodgy(Attributes A ,Attributes B)
        {
            float hitfinal = 0;
            hitfinal = Math.Max(25000, A.hit / (A.hit + B.dodgy * A.GetFightDodgyFactor() * 0.0001f) * 100000 + (A.lv - B.lv) / 5 * A.GetFightLevelMax());
            if (RandomInt(0, 100000) <= hitfinal)
            {
                
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 检查是否绝对闪避
        /// </summary>
        /// <returns>真为闪避,假为命中</returns>
        bool CheckAssolutaDodgy(Attributes A ,Attributes B)
        {

            float aHitfinal = A.hitAssoluta - B.dodgyAssoluta;
            if (aHitfinal >= 100)
            {
                return false;
            }
            else if (aHitfinal > 0 && aHitfinal < 100)
            {
                if (RandomInt(0, 100) <= aHitfinal)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            else if (aHitfinal > -100 && aHitfinal < 0)
            {
                if (RandomInt(-100, 0) < aHitfinal)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (aHitfinal < -100)
            {
                return true;
            }
            else if (aHitfinal == 0)
            {
                return false;
            }






            return false;
        }
        /// <summary>
        /// 计算最终防御
        /// </summary>
        /// <returns>最终对方防御</returns>
        float CalculateDefFinal(Attributes A ,Attributes B)
        {
            var ignoreRate = 0f;
            float ignoreDefRate = 1.0f;

            ignoreRate = A.ignoreAtk - B.ignoreDef;



            if (ignoreRate <= 0)
            {
                //没有无视.防御不变
                ignoreDefRate = 1.0f;
            }
            else if (ignoreRate < 100 && ignoreRate > 0)
            {
                if (RandomInt(0, 100) <= ignoreRate)
                {
                    //无视了,防御减少


                    ignoreDefRate = Math.Max(0.01f, 0.5f - Math.Max(0, A.ignoreAtkAdd * 0.0001f - B.ignoreAtkDec * 0.0001f));


                }
                else
                {
                    //没有无视.防御不变
                    ignoreDefRate = 1.0f;
                }
            }
            else
            {
                //无视了,防御减少

                ignoreDefRate = Math.Max(0.01f, 0.5f - Math.Max(0, A.ignoreAtkAdd * 0.0001f - B.ignoreAtkDec * 0.0001f));


            }

            return B.def * ignoreDefRate;
           
        }
        /// <summary>
        /// 计算攻击速度
        /// </summary>
        /// <returns>角色多少毫秒攻击一次</returns>
        float CalculateSpeed(Attributes A ,Attributes B)
        {
            int speed = 1000;
            speed = (int)(speed * (10000.0f / (10000 + A.atkSpeedAddPercent)));
            return speed;
        }
        /// <summary>
        /// 计算技能系数
        /// </summary>
        /// <returns></returns>
        float CalculateSkillRatioFinal(Attributes A ,Attributes B)
        {
            float skillRatioFinal = 0;
            skillRatioFinal = A.skillRatio * 0.0001f + A.skillRadioAdd * 0.0001f;
            return skillRatioFinal;
        }
        /// <summary>
        /// 计算技能附加伤害
        /// </summary>
        /// <param name="fightType"></param>
        /// <returns></returns>
        float CalculateSkillFixedFinal(Attributes A ,Attributes B)
        {
            float skillFixedFinal = 0;
            skillFixedFinal = A.skillFixed * Math.Max(1, A.skillFixedAdd * 0.0001f);
            return skillFixedFinal;
        }
        /// <summary>
        /// 计算PVP基础伤害
        /// </summary>
        /// <returns></returns>
        float CalculateDamageBasePVP(Attributes A ,Attributes B)
        {
            float damageBase = 0;
            var defFinal = CalculateDefFinal(A, B);
            var atkFinal = CalculateAtkFinal(A, B);
            var skillRatioFinal = CalculateSkillRatioFinal(A, B);
            var skillFixedFinal = CalculateSkillFixedFinal(A, B);
            if (CalculateAtkFinal(A, B) - CalculateDefFinal(A, B) <= 0)
            {
                damageBase = atkFinal * A.GetFightProtectRadioPvp() * skillRatioFinal + skillFixedFinal;
            }
            else if ((CalculateAtkFinal(A, B) - CalculateDefFinal(A, B)) / CalculateAtkFinal(A, B) <= A.GetFightProtectRadioPvp())
            {
                damageBase = ((defFinal - (atkFinal - defFinal)) * A.GetFightProtectRadioPvp() + (atkFinal - defFinal)) * skillRatioFinal + skillFixedFinal;
            }
            else
            {
                damageBase = (atkFinal * A.GetFightProtectRadioPvp() + (atkFinal - defFinal)) * skillRatioFinal + skillFixedFinal;
            }
            return damageBase;
        }
        /// <summary>
        /// 计算PVE基础伤害
        /// </summary>
        /// <param name="fightType"></param>
        /// <returns></returns>
        float CalculateDamageBasePVE(Attributes A ,Attributes B)
        {
            float damageBase = 0;
            var defFinal = CalculateDefFinal(A, B);
            var atkFinal = CalculateAtkFinal(A, B);
            var skillRatioFinal = CalculateSkillRatioFinal(A, B);
            var skillFixedFinal = CalculateSkillFixedFinal(A, B);
            if (CalculateAtkFinal(A, B) - CalculateDefFinal(A, B) <= 0)
            {
                damageBase = atkFinal * A.GetFightProtectRadioPve() * skillRatioFinal + skillFixedFinal;
            }
            else if ((CalculateAtkFinal(A, B) - CalculateDefFinal(A, B)) / CalculateAtkFinal(A, B) <= A.GetFightProtectRadioPve())
            {
                damageBase = ((defFinal - (atkFinal - defFinal)) * A.GetFightProtectRadioPve() + (atkFinal - defFinal)) * skillRatioFinal + skillFixedFinal;
            }
            else
            {
                damageBase = (atkFinal * A.GetFightProtectRadioPve() + (atkFinal - defFinal)) * skillRatioFinal + skillFixedFinal;
            }
            return damageBase;
        }
        /// <summary>
        /// 幸运值伤害计算
        /// </summary>
        /// <param name="luckykey">幸运值</param>
        /// <param name="minAtk">最小攻击</param>
        /// <param name="maxAtk">最大攻击</param>
        /// <returns>最终伤害</returns>
        float CalculateAtkFinal(Attributes A ,Attributes B)
        {
            var minAtk = 0F;
            var midAtk = 0F;
            var maxAtk = 0F;
            var luckykey = 0f;
            minAtk = A.atkMin;
            maxAtk = A.atkMax;
            luckykey = A.luckyKey;

            midAtk = (minAtk + maxAtk) / 2;
            switch (luckykey)
            {
                case 0:
                    if (RandomInt(0, 1000) > 500)
                    {
                        return RandomInt(midAtk, maxAtk);
                    }
                    else
                    {
                        return RandomInt(minAtk, midAtk);
                    }

                case 1:
                    if (RandomInt(0, 1000) > 490)
                    {
                        return RandomInt(midAtk, maxAtk);
                    }
                    else
                    {
                        return RandomInt(minAtk, midAtk);
                    }
                case 2:
                    if (RandomInt(0, 1000) > 470)
                    {
                        return RandomInt(midAtk, maxAtk);
                    }
                    else
                    {
                        return RandomInt(minAtk, midAtk);
                    }
                case 3:
                    if (RandomInt(0, 1000) > 400)
                    {
                        return RandomInt(midAtk, maxAtk);
                    }
                    else
                    {
                        return RandomInt(minAtk, midAtk);
                    }
                case 4:
                    if (RandomInt(0, 1000) > 380)
                    {
                        return RandomInt(midAtk, maxAtk);
                    }
                    else
                    {
                        return RandomInt(minAtk, midAtk);
                    }
                case 5:
                    if (RandomInt(0, 1000) > 360)
                    {
                        return RandomInt(midAtk, maxAtk);
                    }
                    else
                    {
                        return RandomInt(minAtk, midAtk);
                    }
                case 6:
                    if (RandomInt(0, 1000) > 340)
                    {
                        return RandomInt(midAtk, maxAtk);
                    }
                    else
                    {
                        return RandomInt(minAtk, midAtk);
                    }
                case 7:
                    if (RandomInt(0, 1000) > 300)
                    {
                        return RandomInt(midAtk, maxAtk);
                    }
                    else
                    {
                        return RandomInt(minAtk, midAtk);
                    }
                case 8:
                    if (RandomInt(0, 1000) > 200)
                    {
                        return RandomInt(midAtk, maxAtk);
                    }
                    else
                    {
                        return RandomInt(minAtk, midAtk);
                    }
                case 9:
                    if (RandomInt(0, 1000) > 100)
                    {
                        return RandomInt(midAtk, maxAtk);
                    }
                    else
                    {
                        return RandomInt(minAtk, midAtk);
                    }
                case 10:
                    return maxAtk;

            }
            return 0;
        }
        /// <summary>
        /// 判断是否暴击
        /// </summary>
        /// <param name="fightType"></param>
        /// <returns></returns>
        bool CheckCritFinal(Attributes A ,Attributes B)
        {
            var aCritFinal = 0f;
            var critFinal = 0f;
            //是否暴击
            bool ifCrit = false;

            #region 绝对暴击判定
            aCritFinal = A.critAssoluta - B.uncritAssoluta;
            critFinal = Math.Max(5000, A.crit / (A.crit + B.uncrit * A.GetFightCritFactor() * 100000 + (A.lv - B.lv) / 5 * A.GetFightLevelMax()));
            if (aCritFinal >= 100)//必定暴击
            {
                ifCrit = true;
                return ifCrit;
            }
            else if (aCritFinal < 100 && aCritFinal > 0)
            {
                if (RandomInt(0, 100) <= aCritFinal)
                {
                    ifCrit = true;
                    return ifCrit;
                }
                else
                {
                    ifCrit = false;
                }
            }
            else
            {
                ifCrit = false;
            }

            #endregion

            #region 正常暴击判定
            if (RandomInt(0, 100000) < critFinal)
            {
                ifCrit = true;
                return ifCrit;
            }
            else
            {
                ifCrit = false;
            }
            #endregion
            return ifCrit;
        }
        /// <summary>
        /// 计算暴击伤害
        /// </summary>
        /// <param name="fightType"></param>
        /// <returns>暴击伤害比率</returns>
        float CalculateCritFinal(Attributes A ,Attributes B)
        {
            var critInc = 0f;
            var critDec = 0f;
            var critDamageAdd = 0f;
            var critDamageMinus = 0f;
            var critRate = 1.0f;

            critInc = A.critInc;
            critDec = A.critDec;
            critDamageAdd = A.critDamageAdd;
            critDamageMinus = A.critDamageMinus;


            critRate = Math.Max(1, 1.3f + critInc * 0.0001f - critDec * 0.0001f) + critDamageAdd - critDamageMinus;
            return critRate;
        }
        /// <summary>
        /// 检查是否特殊暴击
        /// </summary>
        /// <param name="fightType"></param>
        /// <returns>true为特殊暴击,false为没有</returns>
        SpecialCrit CheckSpecialCritFinal(Attributes A ,Attributes B)
        {
            SpecialCrit specialCrit = SpecialCrit.NoSpecialCrit;
            float greatAtkFinal = 0f, criticalAtkFinal = 0f, luckyAtkFinal = 0f, fatalAtkFinal = 0f;
            greatAtkFinal = Math.Max(0, A.greatAtk - B.greatDef);
            criticalAtkFinal = Math.Max(0, A.criticalAtk - B.criticalDef);
            luckyAtkFinal = Math.Max(0, A.luckyAtk - B.luckyDef);
            fatalAtkFinal = Math.Max(0, A.fatalAtk - B.fatalDef);
            if (greatAtkFinal + criticalAtkFinal + luckyAtkFinal + fatalAtkFinal < 20000)
            {
                int rand = RandomInt(0, 20000);
                if (rand >= 1 && rand < greatAtkFinal)
                {
                    specialCrit = SpecialCrit.GreatAtk;
                }
                else if (rand >= greatAtkFinal && rand < greatAtkFinal + criticalAtkFinal)
                {
                    specialCrit = SpecialCrit.CriticalAtk;
                }
                else if (rand >= greatAtkFinal + criticalAtkFinal && rand <= greatAtkFinal + criticalAtkFinal + luckyAtkFinal)
                {
                    specialCrit = SpecialCrit.LuckyAtk;
                }
                else
                {
                    specialCrit = SpecialCrit.FatalAtk;
                }
            }
            else
            {
                int rand = RandomInt(0, luckyAtkFinal + fatalAtkFinal);
                if (rand < luckyAtkFinal)
                {
                    specialCrit = SpecialCrit.LuckyAtk;
                }
                else
                {
                    specialCrit = SpecialCrit.FatalAtk;
                }
            }

            return specialCrit;
        }
        /// <summary>
        /// 计算特殊暴击伤害
        /// </summary>
        /// <returns></returns>
        float CalculateSpecialCritDamage(Attributes A ,Attributes B, SpecialCrit specialCrit)
        {
            float damageSpecial = 1.0f;
            int greatAtkAddPercent = 0;
            int greatAtkMinusPercent = 0;
            int greatDamageAdd = 0;


            switch (specialCrit)
            {
                //没有特殊暴击
                case SpecialCrit.NoSpecialCrit:
                    break;
                //精绝一击
                case SpecialCrit.GreatAtk:

                    break;
                //会心一击
                case SpecialCrit.CriticalAtk:

                    break;
                //无双一击
                case SpecialCrit.LuckyAtk:

                    break;
                //致命一击
                case SpecialCrit.FatalAtk:

                    break;
                default:
                    break;
            }

            return damageSpecial;
        }
        /// <summary>
        /// 生成min和max之间的真随机数
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int RandomInt(int min,int max)
        {
            Random random = new Random(new Guid().GetHashCode());
            return random.Next(min, max);
        }
        /// <summary>
        /// 生成min和max之间的真随机数
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int RandomInt(float min, float max)
        {
            Random random = new Random(new Guid().GetHashCode());
            return random.Next((int)min, (int)max);
        }
        public static float RandomFloat(float min, float max)
        {
            Random random = new Random(new Guid().GetHashCode());
            var a = random.NextDouble();
            return (float)a * (max - min) + min;
        }
    }
}
