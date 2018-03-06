namespace Auto.Test.Framework
{
    public abstract class ActionBehaviour : IBehavior
    {
        public void Execute()
        {
            PerformAct();
        }
        protected abstract void PerformAct();
    }
}
