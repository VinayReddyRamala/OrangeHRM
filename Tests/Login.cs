using OpenQA.Selenium;
using OrangeHRM.PageObjects;
using OrangeHRM.Utilities;

namespace OrangeHRM.Tests
{
    internal class Login : Base
    {
        [Test,Order(0)]
        [TestCase("Admin","admin123")]
        public void TestLogin(string user,string pass)
        {
            LoginPage login = new LoginPage(driver);

            login.ValidateUser(user, pass);

            //Checking Redirected to Website or Not...
            InterfacePage interfacepage = new InterfacePage(driver);
            IWebElement element = interfacepage.GetLogo();
            if (element != null)
                Assert.Pass();
            else
                Assert.Fail();

        }

        [Test,Order(1)]
        public void TestResetPassword()
        {
            LoginPage login = new LoginPage(driver);
            ResetPasswordPage reset = new ResetPasswordPage(driver);
            login.GetForgotPasswordlik().Click();
            reset.GetUserName().SendKeys("VinayReddy");
            reset.GetBtnResetPass().Click();
            Thread.Sleep(3000);
        }
    }
}