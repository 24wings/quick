using System;
using System.Collections.Generic;
using LolTest.Components.fieldString;
using LolTest.Components.fieldNumber;
using Microsoft.AspNetCore.Components;
using LolTest.Components.fieldDate;

namespace LolTest{
    public static class ComponentRegisterFactory{
        private static Dictionary<Type, ComponentBase> registedComponents = new Dictionary<Type, ComponentBase>();
        private static Dictionary<Type, Type> registedFieldComponents = new Dictionary<Type, Type>(){
            {typeof(String),typeof(FieldString) },
            {typeof(Int32),typeof(FieldNumber)},
            {typeof(DateTime),typeof(FieldDate)}
             
            };

        public static void RegistComponent(Type type,ComponentBase com){
            registedComponents.Add(type,com);
        }

        public static Type GetFieldDefaultComponent(Type type){
            return registedFieldComponents[type];

        }

        

    }
}