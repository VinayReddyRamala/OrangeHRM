using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.PageObjects
{
    internal class LeavePage
    {
        IWebDriver driver;
        public LeavePage(IWebDriver driver) 
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a/span[text()='Leave']")]
        private IWebElement LeaveBtn;

        [FindsBy(How= How.XPath,Using = "//ul/li/a[text()='Apply']")]
        private IWebElement ApplyBtn;

        [FindsBy(How = How.XPath, Using = "//label[text()='Leave Type']/parent::div/following-sibling::div//i")]
        private IWebElement LeaveTypeDropdown;

        [FindsBy(How = How.XPath, Using = "//div[@class='oxd-select-option']/span[text()='CAN - FMLA']")]
        private IWebElement SelectLeaveType;

        [FindsBy(How= How.XPath,Using = "//label[text()='From Date']/parent::div/following-sibling::div//i")]
        private IWebElement FromDateTypeBtn;

        [FindsBy(How = How.XPath, Using = "//label[text()='From Date']/parent::div/following-sibling::div//div[@class='oxd-calendar-wrapper']//ul/li[2]")]
        private IWebElement FromYearsDropdown;

        [FindsBy(How = How.XPath,Using = "//label[text()='From Date']/parent::div/following-sibling::div//div[@class='oxd-calendar-wrapper']//ul/li[2]//li[text()='2000']")]
        private IWebElement FromSelect2000;

        [FindsBy(How = How.XPath,Using = "//label[text()='From Date']/parent::div/following-sibling::div//div[@class='oxd-calendar-wrapper']//ul/li[1]")]
        private IWebElement FromMonthDropdown;

        [FindsBy(How = How.XPath, Using = "//label[text()='From Date']/parent::div/following-sibling::div//div[@class='oxd-calendar-wrapper']//ul/li[1]//li[text()='March']")]
        private IWebElement FromSelectMarch;

        [FindsBy(How = How.XPath,Using = "//label[text()='From Date']/parent::div/following-sibling::div//div[@class='oxd-calendar-wrapper']//div[text()='19']")]
        private IWebElement FromSelectDate;

        [FindsBy(How = How.XPath, Using = "//label[text()='To Date']/parent::div/following-sibling::div//i")]
        private IWebElement ToDateTypeBtn;

        [FindsBy(How = How.XPath, Using = "//label[text()='To Date']/parent::div/following-sibling::div//div[@class='oxd-calendar-wrapper']//ul/li[2]")]
        private IWebElement ToYearsDropdown;

        [FindsBy(How = How.XPath, Using = "//label[text()='To Date']/parent::div/following-sibling::div//div[@class='oxd-calendar-wrapper']//ul/li[2]//li[text()='2000']")]
        private IWebElement ToSelect2000;

        [FindsBy(How=How.XPath,Using = "//label[text()='To Date']/parent::div/following-sibling::div//div[@class='oxd-calendar-wrapper']//ul/li[1]")]
        private IWebElement ToMonthDropdown;

        [FindsBy(How = How.XPath, Using = "//label[text()='To Date']/parent::div/following-sibling::div//div[@class='oxd-calendar-wrapper']//ul/li[1]//li[text()='March']")]
        private IWebElement ToSelectMarch;

        [FindsBy(How = How.XPath, Using = "//label[text()='To Date']/parent::div/following-sibling::div//div[@class='oxd-calendar-wrapper']//div[text()='26']")]
        private IWebElement ToSelectDate;

        [FindsBy(How = How.XPath, Using = "//label[text()='Comments']/parent::div/following-sibling::div/textarea")]
        private IWebElement CommentTxt;


        public void ApplyLeave(string Reason)
        {
            
            LeaveBtn.Click();
            ApplyBtn.Click();
            LeaveTypeDropdown.Click();
            SelectLeaveType.Click();

            FromDateTypeBtn.Click();
            FromYearsDropdown.Click();
            FromSelect2000.Click();
            FromMonthDropdown.Click();
            FromSelectMarch.Click();
            FromSelectDate.Click();

            ToDateTypeBtn.Click();
            ToYearsDropdown.Click();
            ToSelect2000.Click();
            ToMonthDropdown.Click();
            ToSelectMarch.Click();
            ToSelectDate.Click();

            CommentTxt.SendKeys(Reason);

            Thread.Sleep(4000);
        }
    }
}
