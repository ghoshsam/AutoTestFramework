using System;
using System.Collections.Generic;
using System.Text;
using Auto.Test.Framework;
using B2BMage.Test.Pages;

namespace B2BMage.Test.Behaviours
{
    public class LoginBehaviour : ActionBehaviour
    {
        private readonly LoginPage _loginPage;
        public LoginBehaviour(LoginPage loginPage)
        {
            _loginPage = loginPage;
        }
       
        protected override void PerformAct()
        {
            _loginPage.Login("samarendra@insync.co.in", "abcd.1234");
        }
    }
}
