using OpenQA.Selenium;
using OrangeHRM.Utilities;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.PageObjects
{
    internal class MaintenancePage:Base
    {
        IWebDriver driver;
        public MaintenancePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[text()='Maintenance']")]
        private IWebElement MaintenanceBtn;

        [FindsBy(How=How.XPath,Using = "//a[text()='Access Records']")]
        private IWebElement AccessRecordsBtn;
        
        [FindsBy(How=How.XPath,Using = "//label[text()='Employee Name']/parent::div/following-sibling::div//input")]
        private IWebElement EmployeeNameDynamicTxt;

        [FindsBy(How=How.XPath,Using = "//div[@role='listbox']/div[1]")]
        private IWebElement FirstEmployeeName;

        [FindsBy(How = How.XPath, Using = "//button[text()=' Search ']")]
        private IWebElement SearchBtn;

        [FindsBy(How=How.XPath,Using = "//input[@name='firstName']")]
        private IWebElement FoundFirstName;

        public void DownloadEmployeeData()
        {

            MaintenanceBtn.Click();
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[text()=' Confirm ']")).Click();
            AccessRecordsBtn.Click();
            EmployeeNameDynamicTxt.SendKeys("a");
            Thread.Sleep(4000);
            FirstEmployeeName.Click();
            string EmployeeName = EmployeeNameDynamicTxt.Text;
            SearchBtn.Click();
            Thread.Sleep(2000);
            TestContext.Progress.WriteLine(EmployeeName);
        }

    }
}
