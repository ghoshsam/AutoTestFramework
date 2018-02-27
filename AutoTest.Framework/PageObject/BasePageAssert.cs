using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Test.Framework.PageObject
{
    public class BasePageAssert<TE> where TE :new()
    {
        public TE Elements { get => new TE(); }
    }
}
