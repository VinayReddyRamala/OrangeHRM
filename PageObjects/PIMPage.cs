using OpenQA.Selenium;
using OrangeHRM.Utilities;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace OrangeHRM.PageObjects
{
    internal class PIMPage:Base
    {
        InputSimulator robot = new InputSimulator();
        IWebDriver driver;
        public PIMPage(IWebDriver driver) 
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[text()='PIM']/parent::a")]
        private IWebElement PIMBtn;

        [FindsBy(How = How.XPath, Using = "//li/a[text()='Add Employee']")]
        private IWebElement AddEmployeeBtn;

        [FindsBy(How = How.XPath, Using = "//input[@name='firstName']")]
        private IWebElement FirstNameTxt;
        
        [FindsBy(How = How.XPath, Using = "//input[@name='middleName']")]
        private IWebElement MiddleNameTxt;

        [FindsBy(How = How.XPath, Using = "//input[@name='lastName']")]
        private IWebElement LastNameTxt;

        [FindsBy(How = How.XPath, Using = "//label[text()='Employee Id']/parent::div/following-sibling::div/input")]
        private IWebElement EmployeeIdTxt;
        
        [FindsBy(How = How.XPath, Using = "//p[text()='Create Login Details']/following-sibling::div//span")]
        private IWebElement CreateLoginToggle;
        
        [FindsBy(How = How.XPath, Using = "//label[text()='Username']/parent::div/following-sibling::div/input")]
        private IWebElement UsernameTxt;
        
        [FindsBy(How = How.XPath, Using = "//label[text()='Password']/parent::div/following-sibling::div/input")]
        private IWebElement PasswordTxt;
        
        [FindsBy(How = How.XPath, Using = "//label[text()='Confirm Password']/parent::div/following-sibling::div/input")]
        private IWebElement ConformPasswordTxt;
        
        [FindsBy(How = How.XPath, Using = "//button[text()=' Save ']")]
        private IWebElement SaveBtn;

        public void AddEmployeeWithOutLogin(string firstName,string middleName,string lastName,string empId)
        {
            PIMBtn.Click();
            AddEmployeeBtn.Click();
            FirstNameTxt.SendKeys(firstName);
            MiddleNameTxt.SendKeys(middleName);
            LastNameTxt.SendKeys(lastName);
            EmployeeIdTxt.Clear();
            EmployeeIdTxt.SendKeys(empId);

            SaveBtn.Click();
        }

        public void AddEmployeeWithLogin(string firstName, string middleName, string lastName, string empId,string username,string password)
        {
            PIMBtn.Click();
            AddEmployeeBtn.Click();
            FirstNameTxt.SendKeys(firstName);
            MiddleNameTxt.SendKeys(middleName);
            LastNameTxt.SendKeys(lastName);
            EmployeeIdTxt.GetAttribute("");
            EmployeeIdTxt.SendKeys(empId);
            
            CreateLoginToggle.Click();
            UsernameTxt.SendKeys(username);
            PasswordTxt.SendKeys(password);
            ConformPasswordTxt.SendKeys(password);
            
            SaveBtn.Click();
        }
    }
}
