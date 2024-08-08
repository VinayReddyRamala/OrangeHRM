using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.PageObjects
{
    public class InterfacePage
    {
        IWebDriver driver;
        public InterfacePage(IWebDriver driver) 
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//img[@alt='client brand banner']")]
        private IWebElement Logo;

        public IWebElement GetLogo()
        {
            return Logo;
        }

        [FindsBy(How = How.XPath, Using = "//div[@class=\"oxd-topbar-header-title\"]//h6[1]")]
        private IWebElement MainMenu;
        public IWebElement GetMainMenu()
        {
            return MainMenu;
        }
    }
}
