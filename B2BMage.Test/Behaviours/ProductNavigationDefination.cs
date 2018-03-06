using Auto.Test.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace B2BMage.Test.Behaviours
{
    public class ProductNavigationDefination : BehaviourDefinition
    {
        public ProductNavigationDefination (): 
            base(typeof(ProductNavigationBehaviour))
        {
        }
    }
}
