using System;
namespace BuilderPattern
{
    public class HeroBuilder : ActorBuilder
    {
        public override void BuildCostume()
        {
            actor.Costume = "盔甲";
        }

        public override void BuildFace()
        {
            actor.Face = "英俊";
        }

        public override void BuildHairstyle()
        {
            actor.Hairstyle = "飘逸";
        }

        public override void BuildSex()
        {
            actor.Sex = "男";
        }

        public override void BuildType()
        {
            actor.Type = "英雄";
        }
    }
}
