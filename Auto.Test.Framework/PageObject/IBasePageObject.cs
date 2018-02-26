using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Test.Framework.PageObject
{
    public interface IBasePageObject<TE,TA>
    {
        TE Elements { get; }
        TA Asserts { get;}
    }
}
