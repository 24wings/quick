using LolTest.Calc;
using LolTest.Data.Heros;

namespace LolTest.Data.Props{

    /// <summary>
    /// 道具基类
    /// </summary>
     public abstract class PropBase:PropCalc{
         /// <summary>
         /// 道具命
         /// </summary>
         /// <value></value>
         public abstract string Name{get;set;}
         /// <summary>
         /// 道具英文名
         /// </summary>
         /// <value></value>
         public abstract string EnglishName{get;set;}

        /// <summary>
        /// 计算道具优先级别
        /// 级别越大 越优先计算 如帽子 是最后计算的
        /// </summary>
        /// <value></value>
         public abstract int CalcPropPriority{get;set;}
        /// <summary>
        /// 道具图标
        /// </summary>
        /// <value></value>
         public abstract string ImageUrl{get;}
        /// <summary>
        /// 价格
        /// </summary>
        /// <value></value>
        public abstract int Money{get;set;}
        /// <summary>
        /// 唯一
        /// </summary>
        /// <value></value>
        public abstract bool  Uniq{get;set;}
        /// <summary>
        /// 法术强度
        /// </summary>
        /// <value></value>
        public abstract int SpellPower{get;}
        /// <summary>
        /// 攻击速度
        /// </summary>
        /// <value></value>
        public abstract double AttackSpeed{get;}
        /// <summary>
        /// 计算英雄属性
        /// </summary>
        /// <param name="hero"></param>
        /// <returns></returns>
        public abstract void CalcHeroProp(HeroBase hero);
        
     }
}