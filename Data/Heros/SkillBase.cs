namespace LolTest.Data.Heros
{
    public abstract class SkillBase
    {
        public abstract QuickKey Key { get; }
        /// <summary>
        /// 技能Cd
        /// </summary>
        /// <value></value>
        public abstract double Cd{get;set;}
        /// <summary>
        /// 技能说明
        /// </summary>
        /// <value></value>
        public abstract string Detail{get;set;}
    }


    public enum QuickKey
    {

        //被动技能
        Passive,
        Q,
        W,
        E,
        R
    }
}