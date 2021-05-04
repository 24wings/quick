namespace LolTest.Data.Heros{
    /// <summary>
    /// 敌方木桩
    /// </summary>
    public class Army : HeroBase
    {
        public override SkillBase Q{get;}
        public override SkillBase W{get;}
        public override double InitAttackSpeed { get ;}=0;
        public override string Avatar => "/images/muzhuang.png";

        public override string Name => "敌方英雄";

        public override string EnglishName => throw new System.NotImplementedException();

        public override string NickName => "敌方英雄";

        public override string EnglishNickName => throw new System.NotImplementedException();

        public override int ATK { get ;set;}=0;

        public override int InitATK {get;}= 0;

        public override double GrowthATK => 0;

        public override int SpellPower { get  ;set;}=0;
        public override int Level { get ;set;}=1;
        public override int Hp{get;set;}=1000;
        public override double AttackSpeed { get ;set;}=0;

        public override int AttackNumberCalc(int num, HeroBase army)
        {
            throw new System.NotImplementedException();
        }
    }
}