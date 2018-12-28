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


    }
}
