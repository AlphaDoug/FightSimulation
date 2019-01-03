using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMMFight
{
    /// <summary>
    /// 属性类,定义对象的属性,此类应该由代码生成,不应该手动更改
    /// </summary>
    public class Attributes
    {
        /// <summary>
        /// 对象唯一标识符
        /// </summary>
        public int id { set; get; }
        /// <summary>
        /// 对象名称
        /// </summary>
        public string name { set; get; }
        /// <summary>
        /// 对象阵营
        /// </summary>
        public int camp { set; get; }
        /// <summary>
        /// 战力
        /// <summary>
        public float fightForce { set; get; }
        /// <summary>
        /// 等级
        /// </summary>
        public int lv { set; get; }
        /// <summary>
        /// 生命
        /// <summary>
        public float hp { set; get; }
        /// <summary>
        /// 灵力
        /// <summary>
        public float mp { set; get; }
        /// <summary>
        /// 最小攻击
        /// <summary>
        public float atkMin { set; get; }
        /// <summary>
        /// 最大攻击
        /// <summary>
        public float atkMax { set; get; }
        /// <summary>
        /// 防御
        /// <summary>
        public float def { set; get; }
        /// <summary>
        /// 命中
        /// <summary>
        public float hit { set; get; }
        /// <summary>
        /// 闪避
        /// <summary>
        public float dodgy { set; get; }
        /// <summary>
        /// 暴击
        /// <summary>
        public float crit { set; get; }
        /// <summary>
        /// 韧性
        /// <summary>
        public float uncrit { set; get; }
        /// <summary>
        /// 攻击加深
        /// <summary>
        public float atkFixed { set; get; }
        /// <summary>
        /// 技能增伤
        /// <summary>
        public float skillFixed { set; get; }
        /// <summary>
        /// 攻击速度
        /// <summary>
        public float atkSpeed { set; get; }
        /// <summary>
        /// 移动速度
        /// <summary>
        public float runSpeed { set; get; }
        /// <summary>
        /// 生命回复
        /// <summary>
        public float hpRecover { set; get; }
        /// <summary>
        /// 灵力回复
        /// <summary>
        public float mpRecover { set; get; }
        /// <summary>
        /// 暴击增伤
        /// <summary>
        public float critDamageAdd { set; get; }
        /// <summary>
        /// 暴击减伤
        /// <summary>
        public float critDamageMinus { set; get; }
        /// <summary>
        /// 精绝增伤
        /// <summary>
        public float greatDamageAdd { set; get; }
        /// <summary>
        /// 精绝减伤
        /// <summary>
        public float greatDamageMinus { set; get; }
        /// <summary>
        /// 会心增伤
        /// <summary>
        public float criticalDamageAdd { set; get; }
        /// <summary>
        /// 会心减伤
        /// <summary>
        public float criticalDamageMinus { set; get; }
        /// <summary>
        /// 无双增伤
        /// <summary>
        public float luckyDamageAdd { set; get; }
        /// <summary>
        /// 无双减伤
        /// <summary>
        public float luckyDamageMinus { set; get; }
        /// <summary>
        /// 致命增伤
        /// <summary>
        public float fatalDamageAdd { set; get; }
        /// <summary>
        /// 致命减伤
        /// <summary>
        public float fatalDamageMinus { set; get; }
        /// <summary>
        /// 攻击回血
        /// <summary>
        public float atkHpRecover { set; get; }
        /// <summary>
        /// 幸运值
        /// <summary>
        public float luckyKey { set; get; }
        /// <summary>
        /// 性格点数
        /// <summary>
        public float characterPoint { set; get; }
        /// <summary>
        /// 绝对命中
        /// <summary>
        public float hitAssoluta { set; get; }
        /// <summary>
        /// 绝对闪避
        /// <summary>
        public float dodgyAssoluta { set; get; }
        /// <summary>
        /// 绝对暴击
        /// <summary>
        public float critAssoluta { set; get; }
        /// <summary>
        /// 绝对韧性
        /// <summary>
        public float uncritAssoluta { set; get; }
        /// <summary>
        /// 攻速增幅
        /// <summary>
        public float atkSpeedAddPercent { set; get; }
        /// <summary>
        /// 移速增幅
        /// <summary>
        public float runSpeedAddPercent { set; get; }
        /// <summary>
        /// 技能系数
        /// <summary>
        public float skillRatio { set; get; }
        /// <summary>
        /// 技能增幅
        /// <summary>
        public float skillRadioAdd { set; get; }
        /// <summary>
        /// 技能附加增幅
        /// <summary>
        public float skillFixedAdd { set; get; }
        /// <summary>
        /// 攻击增幅
        /// <summary>
        public float atkAddPercent { set; get; }
        /// <summary>
        /// 攻击减幅
        /// <summary>
        public float atkMinusPercent { set; get; }
        /// <summary>
        /// 生命增幅
        /// <summary>
        public float hpAddPercent { set; get; }
        /// <summary>
        /// 生命减幅
        /// <summary>
        public float hpMinusPercent { set; get; }
        /// <summary>
        /// 防御增幅
        /// <summary>
        public float defAddPercent { set; get; }
        /// <summary>
        /// 防御减幅
        /// <summary>
        public float defMinusPercent { set; get; }
        /// <summary>
        /// 命中增幅
        /// <summary>
        public float hitAddPercent { set; get; }
        /// <summary>
        /// 闪避增幅
        /// <summary>
        public float dodgyAddPercent { set; get; }
        /// <summary>
        /// 暴击增幅
        /// <summary>
        public float critAddPercent { set; get; }
        /// <summary>
        /// 韧性增幅
        /// <summary>
        public float uncritAddPercent { set; get; }
        /// <summary>
        /// 伤害加深
        /// <summary>
        public float damageInc { set; get; }
        /// <summary>
        /// 伤害减免
        /// <summary>
        public float damageDec { set; get; }
        /// <summary>
        /// 暴伤加深
        /// <summary>
        public float critInc { set; get; }
        /// <summary>
        /// 暴伤减免
        /// <summary>
        public float critDec { set; get; }
        /// <summary>
        /// 精绝一击
        /// <summary>
        public float greatAtk { set; get; }
        /// <summary>
        /// 精绝抵抗
        /// <summary>
        public float greatDef { set; get; }
        /// <summary>
        /// 会心一击
        /// <summary>
        public float criticalAtk { set; get; }
        /// <summary>
        /// 会心抵抗
        /// <summary>
        public float criticalDef { set; get; }
        /// <summary>
        /// 无双一击
        /// <summary>
        public float luckyAtk { set; get; }
        /// <summary>
        /// 无双抵抗
        /// <summary>
        public float luckyDef { set; get; }
        /// <summary>
        /// 致命一击
        /// <summary>
        public float fatalAtk { set; get; }
        /// <summary>
        /// 致命抵抗
        /// <summary>
        public float fatalDef { set; get; }
        /// <summary>
        /// 精绝增幅
        /// <summary>
        public float greatAtkAddPercent { set; get; }
        /// <summary>
        /// 精绝减幅
        /// <summary>
        public float greatAtkMinusPercent { set; get; }
        /// <summary>
        /// 会心增幅
        /// <summary>
        public float criticalAtkAddPercent { set; get; }
        /// <summary>
        /// 会心减幅
        /// <summary>
        public float criticalAtkMinusPercent { set; get; }
        /// <summary>
        /// 无双增幅
        /// <summary>
        public float luckyAtkAddPercent { set; get; }
        /// <summary>
        /// 无双减幅
        /// <summary>
        public float luckyAtkMinusPercent { set; get; }
        /// <summary>
        /// 致命增幅
        /// <summary>
        public float fatalAtkAddPercent { set; get; }
        /// <summary>
        /// 致命减幅
        /// <summary>
        public float fatalAtkMinusPercent { set; get; }
        /// <summary>
        /// 破甲一击
        /// <summary>
        public float ignoreAtk { set; get; }
        /// <summary>
        /// 破甲抵抗
        /// <summary>
        public float ignoreDef { set; get; }
        /// <summary>
        /// 破甲增幅
        /// <summary>
        public float ignoreAtkAdd { set; get; }
        /// <summary>
        /// 破甲减幅
        /// <summary>
        public float ignoreAtkDec { set; get; }
        /// <summary>
        /// 恢复概率
        /// <summary>
        public float healRate { set; get; }
        /// <summary>
        /// 回复增幅
        /// <summary>
        public float healRadio { set; get; }
        /// <summary>
        /// 生命回复增幅
        /// <summary>
        public float cureRadio { set; get; }
        /// <summary>
        /// 反伤概率
        /// <summary>
        public float reflexRate { set; get; }
        /// <summary>
        /// 反伤
        /// <summary>
        public float thorns { set; get; }
        /// <summary>
        /// 装备基础
        /// <summary>
        public float allEquipBasePercent { set; get; }
        /// <summary>
        /// 装备攻击
        /// <summary>
        public float allEquipAtkPercent { set; get; }
        /// <summary>
        /// 装备生命
        /// <summary>
        public float allEquipHpPercent { set; get; }
        /// <summary>
        /// 装备防御
        /// <summary>
        public float allEquipDefPercent { set; get; }
        /// <summary>
        /// 装备基础
        /// <summary>
        public float singleEquipBasePercent { set; get; }
        /// <summary>
        /// 装备攻击
        /// <summary>
        public float singleEquipAtkPercent { set; get; }
        /// <summary>
        /// 装备生命
        /// <summary>
        public float singleEquipHpPercent { set; get; }
        /// <summary>
        /// 装备防御
        /// <summary>
        public float singleEquipDefPercent { set; get; }
        /// <summary>
        /// PVP加成
        /// <summary>
        public float pvpDamageAddPercent { set; get; }
        /// <summary>
        /// PVP减免
        /// <summary>
        public float pvpDamageMinusPercent { set; get; }
        /// <summary>
        /// 神器加成
        /// <summary>
        public float artifactAddPercent { set; get; }
        /// <summary>
        /// 神器减免
        /// <summary>
        public float artifactMinusPercent { set; get; }
        /// <summary>
        /// 伙伴加成
        /// <summary>
        public float partnerAddPercent { set; get; }
        /// <summary>
        /// 伙伴减免
        /// <summary>
        public float partnerMinusPercent { set; get; }
        /// <summary>
        /// BOSS增伤
        /// <summary>
        public float bossDamageAddPercent { set; get; }
        /// <summary>
        /// 目标血量百分比伤害
        /// <summary>
        public float maxHpPerDamage { set; get; }
        /// <summary>
        /// 伙伴/召唤物继承主角攻击百分比
        /// <summary>
        public float partnerInherit { set; get; }
        /// <summary>
        /// 经验加成
        /// <summary>
        public float expBonus { set; get; }
        /// <summary>
        /// 金币加成
        /// <summary>
        public float killGoldRecover { set; get; }
        /// <summary>
        /// 杀怪回复生命
        /// <summary>
        public float killHpRecover { set; get; }
        /// <summary>
        /// 杀怪回复灵力
        /// <summary>
        public float killMpRecover { set; get; }
        /// <summary>
        /// 等级攻击加成
        /// <summary>
        public float atkLevel { set; get; }
        /// <summary>
        /// 等级防御加成
        /// <summary>
        public float defLevel { set; get; }
        /// <summary>
        /// 掉宝增幅
        /// <summary>
        public float dropRate { set; get; }
        /// <summary>
        /// 基础属性加成
        /// <summary>
        public float partnerAttributeAddPercent { set; get; }
        /// <summary>
        /// 闪避值上限
        /// <summary>
        public float evadeMax { set; get; }
        /// <summary>
        /// 闪避值增加
        /// <summary>
        public float evadeAdd { set; get; }
        /// <summary>
        /// 闪避恢复速度
        /// <summary>
        public float evadeRecover { set; get; }
        /// <summary>
        /// 闪避恢复速度增加
        /// <summary>
        public float evadeRecoverAdd { set; get; }
        /// <summary>
        /// 闪避消耗
        /// <summary>
        public float evadeCost { set; get; }
        /// <summary>
        /// 闪避值消耗变化
        /// <summary>
        public float evadeCostChange { set; get; }
        /// <summary>
        /// 伙伴能量上限
        /// <summary>
        public float partnerEnergyMax { set; get; }
        /// <summary>
        /// 伙伴能量增加值
        /// <summary>
        public float partnerEnergyAdd { set; get; }
        /// <summary>
        /// 伙伴能量消耗
        /// <summary>
        public float partnerEnergyCost { set; get; }
        /// <summary>
        /// 伙伴能量消耗增幅
        /// <summary>
        public float partnerEnergyAddPercent { set; get; }
        /// <summary>
        /// 伙伴能量消耗降幅
        /// <summary>
        public float partnerEnergyMinusPercent { set; get; }
        /// <summary>
        /// 伙伴能量恢复(秒）
        /// <summary>
        public float partnerEnergyGetPerSecond { set; get; }
        /// <summary>
        /// 伙伴能量恢复(秒）增加
        /// <summary>
        public float partnerEnergyGetAdd { set; get; }
        /// <summary>
        /// 命中伙伴能量获取
        /// <summary>
        public float partnerEnergyHitGet { set; get; }
        /// <summary>
        /// 命中伙伴能量获取增加
        /// <summary>
        public float partnerEnergyHitGetAdd { set; get; }
        /// <summary>
        /// 伙伴每秒命中能量获取限制
        /// <summary>
        public float partnerEnergyGetPerSecondLimit { set; get; }
        /// <summary>
        /// 伙伴每秒命中能量限制增加值
        /// <summary>
        public float partnerEnergyGetPerSecondLimitAdd { set; get; }
        /// <summary>
        /// 即时生命
        /// <summary>
        public double GetFightHp()
        {
            return hp * (1 + hpAddPercent * 0.0001 - hpMinusPercent * 0.0001);
        }
        /// <summary>
        /// 即时灵力
        /// <summary>
        public double GetFightMp()
        {
            return mp;
        }
        /// <summary>
        /// 即时最小攻击
        /// <summary>
        public double GetFightAtkMin()
        {
            return (atkMin + atkFixed + atkLevel) * (1 + atkAddPercent * 0.0001 - atkMinusPercent * 0.0001);
        }
        /// <summary>
        /// 即时最大攻击
        /// <summary>
        public double GetFightAtkMax()
        {
            return (atkMax + atkFixed + atkLevel) * (1 + atkAddPercent * 0.0001 - atkMinusPercent * 0.0001);
        }
        /// <summary>
        /// 即时防御
        /// <summary>
        public double GetFightDef()
        {
            return (def + defLevel) * (1 + defAddPercent * 0.0001 - defMinusPercent * 0.0001);
        }
        /// <summary>
        /// 即时命中
        /// </summary>
        public double GetFightHit()
        {
            return hit * (1 + hitAddPercent * 0.0001);
        }
        /// <summary>
        /// 即时闪避
        /// </summary>
        public double GetFightDodgy()
        {
            return dodgy * (1 + dodgyAddPercent * 0.0001);
        }
        /// <summary>
        /// 闪避因子
        /// </summary>
        public int GetFightDodgyFactor()
        {
            return 10000;
        }
        /// <summary>
        /// 即时暴击
        /// </summary>
        public double GetFightCrit()
        {
            return crit * (1 + critAddPercent * 0.0001);
        }
        /// <summary>
        /// 即时韧性
        /// </summary>
        public double GetFightUncrit()
        {
            return uncrit * (1 + uncritAddPercent * 0.0001);
        }
        /// <summary>
        /// 暴击因子
        /// </summary>
        public int GetFightCritFactor()
        {
            return 40000;
        }
        /// <summary>
        /// 攻击加深
        /// </summary>
        public double GetFightAtkFixed()
        {
            return atkFixed * 0.0001;
        }
        /// <summary>
        /// 技能增伤
        /// </summary>
        public double GetFightSkillFixed()
        {
            return skillFixed * (1 + skillFixedAdd * 0.0001);
        }
        /// <summary>
        /// 攻击速度
        /// </summary>
        public double GetFightAtkSpeed()
        {
            return atkSpeed * (1 + atkSpeedAddPercent * 0.0001);
        }
        /// <summary>
        /// 移动速度
        /// </summary>
        public double GetFightRunSpeed()
        {
            return runSpeed * (1 + runSpeedAddPercent * 0.0001);
        }
        /// <summary>
        /// 生命回复
        /// </summary>
        public double GetFightHpRecover()
        {
            return hpRecover;
        }
        /// <summary>
        /// 灵力回复
        /// </summary>
        public double GetFightMpRecover()
        {
            return mpRecover;
        }
        /// <summary>
        /// 暴击增伤
        /// </summary>
        public double GetFightCritDamageAdd()
        {
            return critDamageAdd;
        }
        /// <summary>
        /// 暴击减伤
        /// </summary>
        public double GetFightCritDamageMinus()
        {
            return critDamageMinus;
        }
        /// <summary>
        /// 精绝增伤
        /// </summary>
        public double GetFightGreatDamageAdd()
        {
            return greatDamageAdd;
        }
        /// <summary>
        /// 精绝减伤
        /// </summary>
        public double GetFightGreatDamageMinus()
        {
            return greatDamageMinus;
        }
        /// <summary>
        /// 会心增伤
        /// </summary>
        public double GetFightCriticalDamageAdd()
        {
            return criticalDamageAdd;
        }
        /// <summary>
        /// 会心减伤
        /// <summary>
        public double GetFightCriticalDamageMinus()
        {
            return criticalDamageMinus;
        }
        /// <summary>
        /// 无双增伤
        /// <summary>
        public double GetFightLuckyDamageAdd()
        {
            return luckyDamageAdd;
        }
        /// <summary>
        /// 无双减伤
        /// <summary>
        public double GetFightLuckyDamageMinus()
        {
            return luckyDamageMinus;
        }
        /// <summary>
        /// 致命增伤
        /// <summary>
        public double GetFightFatalDamageAdd()
        {
            return fatalDamageAdd;
        }
        /// <summary>
        /// 致命减伤
        /// <summary>
        public double GetFightFatalDamageMinus()
        {
            return fatalDamageMinus;
        }
        /// <summary>
        /// 攻击回血
        /// <summary>
        public double GetFightAtkHpRecover()
        {
            return atkHpRecover * (1 + cureRadio * 0.0001);
        }
        /// <summary>
        /// 幸运值
        /// <summary>
        public double GetFightLuckyKey()
        {
            return luckyKey;
        }
        /// <summary>
        /// 绝对命中
        /// <summary>
        public double GetFightHitAssoluta()
        {
            return hitAssoluta;
        }
        /// <summary>
        /// 绝对闪避
        /// <summary>
        public double GetFightDodgyAssoluta()
        {
            return dodgyAssoluta;
        }
        /// <summary>
        /// 绝对暴击
        /// <summary>
        public double GetFightCritAssoluta()
        {
            return critAssoluta;
        }
        /// <summary>
        /// 绝对韧性
        /// <summary>
        public double GetFightUncritAssoluta()
        {
            return uncritAssoluta;
        }
        /// <summary>
        /// 攻速增幅
        /// <summary>
        public double GetFightAtkSpeedAddPercent()
        {
            return atkSpeedAddPercent;
        }
        /// <summary>
        /// 移速增幅
        /// <summary>
        public double GetFightRunSpeedAddPercent()
        {
            return runSpeedAddPercent;
        }
        /// <summary>
        /// 技能系数
        /// <summary>
        public double GetFightSkillRatio()
        {
            return (skillRatio + skillRadioAdd) * 0.0001;
        }
        /// <summary>
        /// 技能增幅
        /// <summary>
        public double GetFightSkillRadioAdd()
        {
            return skillRadioAdd * 0.0001;
        }
        /// <summary>
        /// 技能附加增幅
        /// <summary>
        public double GetFightSkillFixedAdd()
        {
            return skillFixedAdd * 0.0001;
        }
        /// <summary>
        /// 攻击增幅
        /// <summary>
        public double GetFightAtkAddPercent()
        {
            return atkAddPercent * 0.0001;
        }
        /// <summary>
        /// 攻击减幅
        /// <summary>
        public double GetFightAtkMinusPercent()
        {
            return atkMinusPercent * 0.0001;
        }
        /// <summary>
        /// 生命增幅
        /// <summary>
        public double GetFightHpAddPercent()
        {
            return hpAddPercent * 0.0001;
        }
        /// <summary>
        /// 生命减幅
        /// <summary>
        public double GetFightHpMinusPercent()
        {
            return hpMinusPercent * 0.0001;
        }
        /// <summary>
        /// 防御增幅
        /// <summary>
        public double GetFightDefAddPercent()
        {
            return defAddPercent * 0.0001;
        }
        /// <summary>
        /// 防御减幅
        /// <summary>
        public double GetFightDefMinusPercent()
        {
            return defMinusPercent * 0.0001;
        }
        /// <summary>
        /// 命中增幅
        /// <summary>
        public double GetFightHitAddPercent()
        {
            return hitAddPercent * 0.0001;
        }
        /// <summary>
        /// 闪避增幅
        /// <summary>
        public double GetFightDodgyAddPercent()
        {
            return dodgyAddPercent * 0.0001;
        }
        /// <summary>
        /// 暴击增幅
        /// <summary>
        public double GetFightCritAddPercent()
        {
            return critAddPercent * 0.0001;
        }
        /// <summary>
        /// 韧性增幅
        /// <summary>
        public double GetFightUncritAddPercent()
        {
            return uncritAddPercent * 0.0001;
        }
        /// <summary>
        /// 伤害加深
        /// <summary>
        public double GetFightDamageInc()
        {
            return damageInc * 0.0001;
        }
        /// <summary>
        /// 伤害减免
        /// </summary>
        public double GetFightDamageDec()
        {
            return damageDec * 0.0001;
        }
        /// <summary>
        /// 暴伤加深
        /// </summary>
        public double GetFightCritInc()
        {
            return critInc * 0.0001;
        }
        /// <summary>
        /// 暴伤减免
        /// </summary>
        public double GetFightCritDec()
        {
            return critDec * 0.0001;
        }
        /// <summary>
        /// 精绝一击
        /// </summary>
        public double GetFightGreatAtk()
        {
            return greatAtk;
        }
        /// <summary>
        /// 精绝抵抗
        /// </summary>
        public double GetFightGreatDef()
        {
            return greatDef;
        }
        /// <summary>
        /// 会心一击
        /// </summary>
        public double GetFightCriticalAtk()
        {
            return criticalAtk;
        }
        /// <summary>
        /// 会心抵抗
        /// </summary>
        public double GetFightCriticalDef()
        {
            return criticalDef;
        }
        /// <summary>
        /// 无双一击
        /// </summary>
        public double GetFightLuckyAtk()
        {
            return luckyAtk;
        }
        /// <summary>
        /// 无双抵抗
        /// </summary>
        public double GetFightLuckyDef()
        {
            return luckyDef;
        }
        /// <summary>
        /// 致命一击
        /// </summary>
        public double GetFightFatalAtk()
        {
            return fatalAtk;
        }
        /// <summary>
        /// 致命抵抗
        /// </summary>
        public double GetFightFatalDef()
        {
            return fatalDef;
        }
        /// <summary>
        /// 精绝增幅
        /// </summary>
        public double GetFightGreatAtkAddPercent()
        {
            return greatAtkAddPercent * 0.0001;
        }
        /// <summary>
        /// 精绝减幅
        /// </summary>
        public double GetFightGreatAtkMinusPercent()
        {
            return greatAtkMinusPercent * 0.0001;
        }
        /// <summary>
        /// 会心增幅
        /// </summary>
        public double GetFightCriticalAtkAddPercent()
        {
            return criticalAtkAddPercent * 0.0001;
        }
        /// <summary>
        /// 会心减幅
        /// </summary>
        public double GetFightCriticalAtkMinusPercent()
        {
            return criticalAtkMinusPercent * 0.0001;
        }
        /// <summary>
        /// 无双增幅
        /// </summary>
        public double GetFightLuckyAtkAddPercent()
        {
            return luckyAtkAddPercent * 0.0001;
        }
        /// <summary>
        /// 无双减幅
        /// </summary>
        public double GetFightLuckyAtkMinusPercent()
        {
            return luckyAtkMinusPercent * 0.0001;
        }
        /// <summary>
        /// 致命增幅
        /// </summary>
        public double GetFightFatalAtkAddPercent()
        {
            return fatalAtkAddPercent * 0.0001;
        }
        /// <summary>
        /// 致命减幅
        /// </summary>
        public double GetFightFatalAtkMinusPercent()
        {
            return fatalAtkMinusPercent * 0.0001;
        }
        /// <summary>
        /// 破甲一击
        /// </summary>
        public double GetFightIgnoreAtk()
        {
            return ignoreAtk;
        }
        /// <summary>
        /// 破甲抵抗
        /// </summary>
        public double GetFightIgnoreDef()
        {
            return ignoreDef;
        }
        /// <summary>
        /// 破甲增幅
        /// </summary>
        public double GetFightIgnoreAtkAdd()
        {
            return ignoreAtkAdd * 0.0001;
        }
        /// <summary>
        /// 破甲减幅
        /// </summary>
        public double GetFightIgnoreAtkDec()
        {
            return ignoreAtkDec * 0.0001;
        }
        /// <summary>
        /// 恢复概率
        /// </summary>
        public double GetFightHealRate()
        {
            return healRate;
        }
        /// <summary>
        /// 回复增幅
        /// </summary>
        public double GetFightHealRadio()
        {
            return healRadio * 0.0001;
        }
        /// <summary>
        /// 生命回复增幅
        /// </summary>
        public double GetFightCureRadio()
        {
            return cureRadio * 0.0001;
        }
        /// <summary>
        /// 反伤概率
        /// </summary>
        public double GetFightReflexRate()
        {
            return 0.3 + reflexRate * 0.0001;
        }
        /// <summary>
        /// 反伤
        /// </summary>
        public double GetFightThorns()
        {
            return thorns;
        }
        /// <summary>
        /// PVP加成
        /// </summary>
        public double GetFightPvpDamageAddPercent()
        {
            return pvpDamageAddPercent * 0.0001;
        }
        /// <summary>
        /// PVP减免
        /// </summary>
        public double GetFightPvpDamageMinusPercent()
        {
            return pvpDamageMinusPercent * 0.0001;
        }
        /// <summary>
        /// 神器加成
        /// </summary>
        public double GetFightArtifactAddPercent()
        {
            return artifactAddPercent * 0.0001;
        }
        /// <summary>
        /// 神器减免
        /// </summary>
        public double GetFightArtifactMinusPercent()
        {
            return artifactMinusPercent * 0.0001;
        }
        /// <summary>
        /// 伙伴加成
        /// </summary>
        public double GetFightPartnerAddPercent()
        {
            return partnerAddPercent * 0.0001;
        }
        /// <summary>
        /// 伙伴减免
        /// </summary>
        public double GetFightPartnerMinusPercent()
        {
            return partnerMinusPercent * 0.0001;
        }
        /// <summary>
        /// BOSS加成
        /// </summary>
        public double GetFightBossDamageAddPercent()
        {
            return bossDamageAddPercent * 0.0001;
        }
        /// <summary>
        /// 目标血量百分比伤害
        /// </summary>
        public double GetFightMaxHpPerDamage()
        {
            return maxHpPerDamage * 0.0001;
        }
        /// <summary>
        /// 伙伴/召唤物继承主角攻击百分比
        /// </summary>
        public double GetFightPartnerInherit()
        {
            return partnerInherit * 0.0001;
        }
        /// <summary>
        /// 经验加成
        /// </summary>
        public double GetFightExpBonus()
        {
            return expBonus * 0.0001;
        }
        /// <summary>
        /// 金币加成
        /// </summary>
        public double GetFightKillGoldRecover()
        {
            return killGoldRecover * 0.0001;
        }
        /// <summary>
        /// 杀怪回复生命
        /// </summary>
        public double GetFightKillHpRecover()
        {
            return killHpRecover;
        }
        /// <summary>
        /// 杀怪回复灵力
        /// </summary>
        public double GetFightKillMpRecover()
        {
            return killMpRecover;
        }
        /// <summary>
        /// 等级攻击加成
        /// </summary>
        public double GetFightAtkLevel()
        {
            return atkLevel;
        }
        /// <summary>
        /// 等级防御加成
        /// <summary>
        public double GetFightDefLevel()
        {
            return defLevel;
        }
        /// <summary>
        /// 血量上限
        /// </summary>
        public double GetFightHpMax()
        {
            return hp;
        }
        /// <summary>
        /// PVE保底伤害系数
        /// </summary>
        public float GetFightProtectRadioPve()
        {
            return 0.05f;
        }
        /// <summary>
        /// PVP保底伤害系数
        /// </summary>
        public float GetFightProtectRadioPvp()
        {
            return 0.1f;
        }
        /// <summary>
        /// 每个版本下等级上限
        /// </summary>
        public int GetFightLevelMax()
        {
            return 1000;
        }
        /// <summary>
        /// 攻击方等级
        /// </summary>
        public double GetFightLevel()
        {
            return 0;
        }
        /// <summary>
        /// 暴击默认伤害倍率
        /// </summary>
        public double GetFightCritDamageMultipler()
        {
            return 1.3;
        }
        /// <summary>
        /// 精绝一击默认伤害倍率
        /// </summary>
        public double GetFightGreatAtkDamageMultipler()
        {
            return 1.3;
        }
        /// <summary>
        /// 会心一击默认伤害倍率
        /// </summary>
        public double GetFightCriticalAtkDamageMultipler()
        {
            return 1.5;
        }
        /// <summary>
        /// 无双一击默认伤害倍率
        /// </summary>
        public double GetFightLuckyAtkDamageMultipler()
        {
            return 2;
        }
        /// <summary>
        /// 致命一击默认伤害倍率
        /// </summary>
        public double GetFightFatalAtkDamageMultipler()
        {
            return Fight.RandomFloat(3, 5);
        }
        /// <summary>
        /// 伙伴默认对BOSS伤害加成倍率
        /// </summary>
        public double GetFightPartnerDamageAdd()
        {
            return 1.2;
        }

    }
}
