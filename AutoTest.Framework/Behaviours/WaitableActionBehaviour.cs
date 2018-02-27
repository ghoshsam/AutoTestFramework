using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Test.Framework.Behaviours
{
    public abstract class WaitableActionBehaviour : IBehaviour
    {
        public void Execute()
        {
            PerformAct();
            PerformPostActWait();
        }

        protected abstract void PerformAct();
        protected abstract void PerformPostActWait();
    }
}
