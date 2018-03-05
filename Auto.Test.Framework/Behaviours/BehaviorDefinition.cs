using System;

namespace Auto.Test.Framework
{
    public abstract class BehaviorDefinition
    {
        public BehaviorDefinition(Type behaviorType)
        {
            BehaviorType = behaviorType;
        }
        internal Type BehaviorType { get; private set; }
    }
}
