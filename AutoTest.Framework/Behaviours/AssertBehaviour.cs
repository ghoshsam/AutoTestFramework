using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Test.Framework.Behaviours
{
    public abstract class AssertBehaviour : IBehaviour
    {
        public void Execute()
        {
            Assert();
        }
        protected abstract void Assert();
    }
}
