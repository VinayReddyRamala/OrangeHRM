using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrangeHRM.Utilities;
using AngleSharp.Html.Dom;
using OpenQA.Selenium.Support.UI;

namespace OrangeHRM.PageObjects
{
    internal class AdminPage
    {
        IWebDriver driver;
        public AdminPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        //finding Admin Button in Main Menue...
        [FindsBy(How = How.XPath, Using = "//span[text()='Admin']/parent::a")]
        private IWebElement AdminBtn;


        //finding Add Button in Admin Page...
        [FindsBy(How = How.XPath, Using = "//button[text()=' Add ']")]
        private IWebElement Addbtn;


        //           ---------Adding User---------            //

        //finding role dropdown...
        [FindsBy(How = How.XPath, Using = "//div[text()='-- Select --']")]
        private IWebElement RoleDropdown;


        //finding Admin role option from the dropdown...
        [FindsBy(How = How.XPath, Using = "//div[@class='oxd-select-option']/span")]
        private IWebElement AdminOption;


        //finding employee name dymanic textbox...
        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Type for hints...']")]
        private IWebElement EmpNametxt;


        //finding employee name dynamic options...
        [FindsBy(How = How.XPath, Using = "//div/span[text()='raghav vadla chary']")]
        private IWebElement EmployeeName;



        //span[text()='Enabled']/parent::div
        //finding status dropdown...
        [FindsBy(How = How.XPath, Using = "//label[text()='Status']/following::i")]
        private IWebElement StatusDropdown;


        //finding enabled option in status options...
        [FindsBy(How = How.XPath, Using = "//div[@class='oxd-select-option']/span")]
        private IWebElement EnabledOption;


        //finding username textbox...
        [FindsBy(How = How.XPath, Using = "//label[text()='Username']/following::input")]
        private IWebElement UsernameTxt;


        //finding password textbox...
        [FindsBy(How = How.XPath, Using = "//label[text()='Password']/following::input")]
        private IWebElement PasswordTxt;


        //finding Conforn password textbox...
        [FindsBy(How = How.XPath, Using = "//label[text()='Confirm Password']/following::input")]
        private IWebElement ConfPassTxt;


        //finding Save Button...
        [FindsBy(How = How.XPath, Using = "//button[text()=' Save ']")]
        private IWebElement SaveBtn;

        //finding Cancel Button...
        [FindsBy(How = How.XPath, Using = "//button[text()=' Cancel ']")]
        private IWebElement CancelBtn;

        //Method to Add a New User...
        public void AddNewUser(string UserName, string Password, string EmployeeName)
        {
            AdminBtn.Click();
            Addbtn.Click();
            RoleDropdown.Click();
            AdminOption.Click();
            EmpNametxt.SendKeys(EmployeeName);
            StatusDropdown.Click();
            EnabledOption.Click();
            UsernameTxt.SendKeys(UserName);
            PasswordTxt.SendKeys(Password);
            ConfPassTxt.SendKeys(Password);
            SaveBtn.Click();
            CancelBtn.Click();

            Thread.Sleep(3000);
        }

        //          ------------  Searching User  ---------              //


        //Getting UserName from the list...
        [FindsBy(How = How.XPath, Using = "//div[@class='oxd-table-cell oxd-padding-cell'][2]/div")]
        private IWebElement User1;

        //Getting Employee Name From the List...
        [FindsBy(How = How.XPath, Using = "//div[@class='oxd-table-cell oxd-padding-cell'][4]/div")]
        private IWebElement Emp1;

        //Getting User Role From the List...
        [FindsBy(How = How.XPath, Using = "//div[@class='oxd-table-cell oxd-padding-cell'][3]/div")]
        private IWebElement Role1;



        //div[@class='oxd-table-cell oxd-padding-cell'][2]/div
        [FindsBy(How = How.XPath, Using = "//label[text()='Username']/parent::div/following-sibling::div/input")]
        private IWebElement Username;

        [FindsBy(How = How.XPath, Using = "//label[text()='User Role']/parent::div//following-sibling::div//i")]
        private IWebElement SelectRoledropdown;
        [FindsBy(How = How.XPath, Using = "//span[text()='Admin']/parent::div")]
        private IWebElement SelectAdmin;

        [FindsBy(How = How.XPath, Using = "//label[text()='Employee Name']/parent::div/following-sibling::div//input")]
        private IWebElement Employeename;

        //Select Employee Name...
        [FindsBy(How = How.XPath, Using = "//span/parent::div[@class='oxd-autocomplete-option']")]
        private IWebElement SelectEmployee;

        [FindsBy(How = How.XPath, Using = "//label[text()='Status']/parent::div/following-sibling::div//i")]
        private IWebElement Statusdropdown;
        [FindsBy(How = How.XPath, Using = "//span[text()='Enabled']/parent::div")]
        private IWebElement Enabledoption;

        [FindsBy(How = How.XPath, Using = "//button[text()=' Search ']")]
        private IWebElement SearchBtn;



        public void SearchUser(string username, string EmployeeName)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='oxd-table-cell oxd-padding-cell'][2]/div")));

            Username.SendKeys(User1.Text);
            SelectRoledropdown.Click();
            SelectAdmin.Click();
            Employeename.SendKeys(Emp1.Text);
            SelectEmployee.Click();
            Statusdropdown.Click();
            Enabledoption.Click();
            SearchBtn.Click();

            Thread.Sleep(2000);
        }
    }
}
