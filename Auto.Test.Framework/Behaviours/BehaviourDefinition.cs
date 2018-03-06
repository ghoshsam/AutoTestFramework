using System;

namespace Auto.Test.Framework
{
    public abstract class BehaviourDefinition
    {
        public BehaviourDefinition(Type behaviorType)
        {
            BehaviorType = behaviorType;
        }
        internal Type BehaviorType { get; private set; }
    }
}
