using System;

namespace Auto.Test.Framework
{
    public class BehaviorDefinitionEngine
    {

        public void Execute(params BehaviourDefinition[] behaviorDefinition)
        {
            foreach (BehaviourDefinition defination in behaviorDefinition)
            {
                IBehavior behavior = Activator.CreateInstance(defination.BehaviorType) as Behavior;
                behavior.Execute();
            }
        }
    }
}
