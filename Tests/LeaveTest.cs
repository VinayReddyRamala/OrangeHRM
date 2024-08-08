using OpenQA.Selenium;
using OrangeHRM.PageObjects;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Tests
{
    internal class LeaveTest:Base
    {
        
        [Test,Order(5)]
        public void ApplyLeave()
        {
            PerformLogin();
            LeavePage leave = new LeavePage(driver);
            leave.ApplyLeave("Feaver");
        }
    }
}
