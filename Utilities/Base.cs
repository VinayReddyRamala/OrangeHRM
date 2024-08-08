using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OrangeHRM.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace OrangeHRM.Utilities
{

    public class Base
    {
        public IWebDriver driver;
        

        [SetUp]
        public void Setup()
        {
            string BrowserName = ConfigurationManager.AppSettings["browser"];
            InitBrowser(BrowserName);
            driver.Manage().Window.Maximize();
            driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }


        public void InitBrowser(string BrowserName)
        {
            switch (BrowserName)
            {
                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;
                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;
            }
        }

        public void PerformLogin()
        {
            LoginPage login = new LoginPage(driver);
            login.ValidateUser("Admin", "admin123");
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
    
}
