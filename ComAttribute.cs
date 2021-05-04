using System;

namespace LolTest{
    public class ComAttribute:Attribute{
        public Type type{get;set;}
        public ComAttribute(Type type){
            this.type=type;
        }
    }
}