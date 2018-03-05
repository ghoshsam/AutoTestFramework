namespace Auto.Test.Framework
{
    public interface IBasePageObject<TE,TA>
    {
        TE Elements { get; }
        TA Asserts { get;}
    }
}
