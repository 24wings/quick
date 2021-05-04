using System;
using LolTest.Data.Heros;

namespace LolTest.Data.Props{
    /// <summary>
    /// 纳什之牙
    /// </summary>
    public class NashorTooth : PropBase
    {
        public override string Name {get;set; }="纳什之牙";
        public override string EnglishName { get;set; }="Nashor’s Tooth";
        public override int CalcPropPriority {get;set; }=10;

        public override string ImageUrl{get;}="/images/nashor.png";

        public override bool Uniq{get;set;}=true;
        public override int Money { get;set;}=3000;

        public override int SpellPower {get;}=100;

        public override double AttackSpeed {get;}=0.5;


        public override int CalcByAttackOnce(HeroBase me, HeroBase army)
        {
          return Convert.ToInt32(15+me.SpellPower*0.2);
        }

        public override void CalcHeroProp(HeroBase hero){
          hero.SpellPower+=SpellPower;
          hero.AttackSpeed+=hero.InitAttackSpeed*AttackSpeed;
        }

    
    }
}