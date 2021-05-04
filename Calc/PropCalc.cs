using System.Collections.Generic;
using LolTest.Data.Props;
using LolTest.Data.Heros;

namespace LolTest.Calc{
    /// <summary>
    /// 道具计算伤害方式
    /// </summary>
    public abstract class PropCalc : CalcBase
    {



        public override string way => "道具计算伤害方式";

    public static void  CalcPropAttribute(List<PropBase> propList,HeroBase hero){
          hero.PropList.Sort((prop1,prop2)=>prop1.CalcPropPriority-prop2.CalcPropPriority);
          
    }

        /// <summary>
        /// 一次攻击造成的伤害
        /// </summary>
        /// <param name="me"></param>
        /// <param name="army"></param>
        /// <returns></returns>
        public abstract int CalcByAttackOnce(HeroBase me,HeroBase army);
    }
}