using System.Collections.Generic;
using LolTest.Data.Props;

namespace LolTest.Data.Heros
{
    /// <summary>
    /// 英雄基础属性
    /// </summary>
    public abstract class HeroBase
    {
        /// <summary>
        /// Q技能
        /// </summary>
        /// <value></value>
        public abstract SkillBase Q{get;}
        /// <summary>
        /// W技能
        /// </summary>
        /// <value></value>
        public abstract SkillBase W{get;}
        /// <summary>
        /// 英雄初始攻击速度
        /// </summary>
        /// <value></value>
        public abstract double InitAttackSpeed{get;}
        /// <summary>
        /// 生命值
        /// </summary>
        /// <value></value>
        public abstract int Hp{get;set;}
        /// <summary>
        /// 头像
        /// </summary>
        /// <value></value>
        public abstract string Avatar{get;}
        /// <summary>
        /// 英雄名字
        /// </summary>
        /// <value></value>
        public abstract string Name { get; }
        /// <summary>
        /// 英雄英文名字
        /// </summary>
        /// <value></value>
        public abstract string EnglishName { get; }
        /// <summary>
        /// 攻击速度
        /// </summary>
        /// <value></value>
        public abstract double AttackSpeed { get; set; }
        /// <summary>
        /// 英雄外号
        /// </summary>
        /// <value></value>
        public abstract string NickName { get; }
        /// <summary>
        /// 英文外号
        /// </summary>
        /// <value></value>
        public abstract string EnglishNickName { get; }

        /// <summary>
        /// 物理攻击力
        /// </summary>
        /// <value></value>
        public abstract int ATK { get; set; }
        /// <summary>
        /// 初始物理攻击力
        /// </summary>
        /// <value></value>
        public abstract int InitATK{get;}
        /// <summary>
        /// 成长攻击力
        /// </summary>
        /// <value></value>
        public abstract double GrowthATK { get; }
        /// <summary>
        /// 法术强度
        /// </summary>
        /// <value></value>
        public abstract int SpellPower{get;set;}
        /// <summary>
        /// 英雄等级
        /// </summary>
        /// <value></value>
        public abstract int Level{get;set;}
     
        /// <summary>
        /// 根据攻击次数计算伤害
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public abstract int AttackNumberCalc(int num,HeroBase army);



      

        /// <summary>
        /// 道具列表
        /// </summary>
        /// <value></value>
        public  List<PropBase> PropList{get;set;}=new List<PropBase>();



        public void AddProp(PropBase prop){
            PropList.Add(prop);
            PropList.Sort((prop1,prop2)=>prop1.CalcPropPriority-prop2.CalcPropPriority);
            prop.CalcHeroProp(this);

        }



    }
}