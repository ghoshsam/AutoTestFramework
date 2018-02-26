using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Test.Framework.Behaviours
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
