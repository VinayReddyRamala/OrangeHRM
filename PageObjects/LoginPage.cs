using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
namespace OrangeHRM.PageObjects
{
    public class LoginPage
    {
        //loginBtn  //div[@class="oxd-form-actions orangehrm-login-action"]/button[@type='submit']
        IWebDriver driver;
        public LoginPage(IWebDriver driver) 
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        //Username
        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement username;
        public IWebElement GetUsername()
        {
            return username;
        }

        //Password
        [FindsBy(How =How.Name,Using = "password")]
        private IWebElement password;
        public IWebElement GetPassword()
        {
            return password;
        }

        //LoginBtn
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement LoginBtn;
        public IWebElement GetLoginBtn()
        {
            return LoginBtn;
        }

        //Forgot Password
        [FindsBy(How = How.XPath, Using = "//p[text()='Forgot your password? ']")]
        private IWebElement ForgotPassword;
        public IWebElement GetForgotPasswordlik()
        {
            return ForgotPassword;
        }



        public void ValidateUser(string user,string pass)
        {
            username.SendKeys(user);
            password.SendKeys(pass);
            LoginBtn.Click();
        }
    }
}
