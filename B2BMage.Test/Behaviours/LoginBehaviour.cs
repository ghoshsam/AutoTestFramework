using System;
using System.Collections.Generic;
using System.Text;
using Auto.Test.Framework;
using B2BMage.Test.Pages;

namespace B2BMage.Test.Behaviours
{
    public class LoginBehaviour : Behavior
    {
        private readonly LoginPage _loginPage;
        public LoginBehaviour(LoginPage loginPage)
        {
            _loginPage = loginPage;
        }
        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
