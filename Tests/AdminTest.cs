using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OrangeHRM.PageObjects;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Tests
{
    internal class AdminTest:Base
    {
        [Test, Order(2)]
        public void Admin()
        {
            Actions actions = new Actions(driver);
            PerformLogin();
            Thread.Sleep(3000);
            AdminPage admin = new AdminPage(driver);

            admin.AddNewUser("Vinay", "Vinayreddy143", "raghav vadla chary");
            admin.SearchUser("Admin", "\r\nnarasimha g");

            Thread.Sleep(5000);
        }
    }
}
