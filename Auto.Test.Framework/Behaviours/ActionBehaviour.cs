using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Test.Framework.Behaviours
{
    public abstract class ActionBehaviour : IBehaviour
    {
        public void Execute()
        {
            PerformAct();
        }
        protected abstract void PerformAct();
    }
}
