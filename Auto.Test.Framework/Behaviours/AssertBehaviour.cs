namespace Auto.Test.Framework
{
    public abstract class AssertBehaviour : IBehavior
    {
        public void Execute()
        {
            Assert();
        }
        protected abstract void Assert();
    }
}
