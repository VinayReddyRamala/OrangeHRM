using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.PageObjects
{
    internal class RecruitmentPage
    {
        IWebDriver driver;
        string VacancyName, NoofVacancies;
        public RecruitmentPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        //      -----------------Adding a Vacancy---------------       //

        [FindsBy(How = How.XPath, Using = "//a/span[text()='Recruitment']")]
        private IWebElement RecruitmentBtn;
        
        [FindsBy(How = How.XPath, Using = "//a[text()='Vacancies']")]
        private IWebElement VacanciesBtn;

        [FindsBy(How = How.XPath, Using = "//button[text()=' Add ']")]
        private IWebElement AddBtn;

        [FindsBy(How=How.XPath,Using = "//label[text()='Vacancy Name']/parent::div/following-sibling::div/input")]
        private IWebElement VacancyNameTxt;
        
        [FindsBy(How=How.XPath,Using = "//label[text()='Job Title']/parent::div/following-sibling::div//i")]
        private IWebElement JobTitleDropdown;
        
        [FindsBy(How=How.XPath,Using = "//div[@role='option']/span[text()='Software Engineer']")]
        private IWebElement SoftwareEngineerOption;

        [FindsBy(How = How.XPath, Using = "//label[text()='Description']/parent::div/following-sibling::div/textarea")]
        private IWebElement DescriptionTxt;

        [FindsBy(How= How.XPath,Using = "//label[text()='Hiring Manager']/parent::div/following-sibling::div//input")]
        private IWebElement HiringManageDynamicTxt;
        
        

        [FindsBy(How= How.XPath,Using = "//div[@role='listbox']/div[@role='option'][1]")]
        private IWebElement HiringManageOption;

        [FindsBy(How = How.XPath, Using = "//label[text()='Number of Positions']/parent::div/following-sibling::div/input")]
        private IWebElement NoofVacanciesTxt;
        
        [FindsBy(How = How.XPath, Using = "//button[text()=' Save ']")]
        private IWebElement SaveBtn;
        
        [FindsBy(How = How.XPath, Using = "//button[text()=' Cancel ']")]
        private IWebElement CancelBtn;



        public void AddVacancy(string VacancyName,string NoofVacancies,string Description)
        {
            
            RecruitmentBtn.Click();
            VacanciesBtn.Click();
            AddBtn.Click();
            VacancyNameTxt.SendKeys(VacancyName);
            JobTitleDropdown.Click();
            SoftwareEngineerOption.Click();
            DescriptionTxt.Click();

            HiringManageDynamicTxt.SendKeys("a");
            Thread.Sleep(3000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@role='listbox']/div[@role='option'][1]")));
            
            HiringManageOption.Click();
            NoofVacanciesTxt.SendKeys(NoofVacancies);
            SaveBtn.Click();
            CancelBtn.Click();

        }




    }
}
