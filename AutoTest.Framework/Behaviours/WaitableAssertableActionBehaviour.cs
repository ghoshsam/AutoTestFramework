using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Test.Framework.Behaviours
{
    public abstract class WaitableAssertableActionBehaviour : IBehaviour
    {
        public void Execute()
        {
            PerformPreActWait();
            PerformPreActAssert();
            PerformAct();
            PerformPostActAssert();
            PerformPostActWait();
            PerformPostActWaitAssert();
        }
        protected virtual void PerformPreActWait()
        {
        }

        protected virtual void PerformPreActAssert()
        {
        }

        protected virtual void PerformAct()
        {
        }

        protected virtual void PerformPostActAssert()
        {
        }

        protected virtual void PerformPostActWait()
        {
        }

        protected virtual void PerformPostActWaitAssert()
        {
        }
    }
}
