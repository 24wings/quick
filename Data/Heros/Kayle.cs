using System;
using System.Collections.Generic;
using LolTest.Data.Props;
namespace LolTest.Data.Heros
{
    /// <summary>
    /// 正义天使 凯尔
    /// </summary>
    public class Kayle : HeroBase
    {
        public override string Avatar => "/images/Kayle.png";
        public override string Name { get => "凯尔"; }
        public override string EnglishName { get => "Kayle"; }
        public override string NickName { get => "正义天使"; }

        public override string EnglishNickName => "The Rightrous";
        public override int InitATK => 50;
        public override int ATK { get; set; } = 50;
        public override double GrowthATK { get; } = 2.5;
        public override int SpellPower { set; get; } = 0;
        public override int Level { get; set; } = 1;
        public override int Hp { get;set;}=600;
        public override double AttackSpeed{get;set;}=0.667;

        public override double InitAttackSpeed => 0.667;

        public override SkillBase Q => new KayleQ();

        public override SkillBase W => throw new NotImplementedException();

        public override int AttackNumberCalc(int num, HeroBase army)
        {

            // E技能被动伤害
            var eAttack = EAttackByOnce() * num * (Level >= 11 ? 2 : 1);
            var propDamange = 0;
            PropList.ForEach(prop =>
            {
                propDamange += prop.CalcByAttackOnce(this, army);
            });


            return ATK * num + eAttack + propDamange;
        }
        /// <summary>
        /// E技能攻击一次伤害
        /// </summary>
        /// <returns></returns>
        public int EAttackByOnce()
        {
            return Convert.ToInt32((35 + (ATK - InitATK) * 0.1 + SpellPower * 0.2));
        }
    }
    /// <summary>
    /// 凯尔Q技能
    /// </summary>
    public class KayleQ : SkillBase
    {
        

        public override QuickKey Key { get ; }=QuickKey.Q;
        public override double Cd { get;set;}=9;
        public override string Detail { get ;set; }=@"
                                        凯尔召唤一把星界之剑，它会停留在命中的第一个敌人身上。

星界之剑对目标及其身后的敌人造成（60/100/140/180/220+50%AP+60%额外AD）魔法伤害，26/32/38/44/50%减速效果，持续2秒，并击碎15%的护甲和魔法抗性，持续4秒。


冷却时间（秒）: 12/11/10/9/8
法力值消耗: 70/75/80/85/90
範圍: 900
                                    ";
    }
}