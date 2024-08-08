using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.PageObjects
{
    public class ResetPasswordPage
    {
        IWebDriver driver;
        public ResetPasswordPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        

        //Username
        [FindsBy(How = How.XPath, Using = "//input[@name='username']")]
        private IWebElement username;
        public IWebElement GetUserName()
        {
            return username;
        }

        //ResetPasswoed
        [FindsBy(How = How.XPath, Using = "//div[@class='orangehrm-forgot-password-button-container']/button[2]")]
        private IWebElement ResetPass;
        public IWebElement GetBtnResetPass()
        {
            return ResetPass;
        }

        public void ForgotPassword()
        {
            
        }

    }
}
