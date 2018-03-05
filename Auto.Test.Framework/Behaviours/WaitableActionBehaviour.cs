namespace Auto.Test.Framework
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
