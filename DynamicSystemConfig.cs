using System;
using System.Reflection;

using LolTest.Components.fieldString;
namespace LolTest{

    /// <summary>
    /// 系统配置类
    /// </summary>
    public static class DynamicSystemConfig{
        
        /// <summary>
        /// 默认string 表单字段
        /// </summary>
        /// <returns></returns>
        public static Type DefaultFieldStringComponent{get;set;}=typeof(FieldString);

    }
    
}