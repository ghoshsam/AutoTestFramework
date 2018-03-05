namespace Auto.Test.Framework
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
