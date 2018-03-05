namespace Auto.Test.Framework
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
