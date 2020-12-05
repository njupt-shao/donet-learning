using System;
namespace BuilderPattern
{
    public class ActorController
    {
        public Actor GetActor(ActorBuilder actorBuilder)
        {
            
            actorBuilder.BuildCostume();
            actorBuilder.BuildFace();
            actorBuilder.BuildHairstyle();
            actorBuilder.BuildSex();
            actorBuilder.BuildType();
            return actorBuilder.GetActor();
        }
    }
}
