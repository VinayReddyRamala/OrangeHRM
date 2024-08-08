using OrangeHRM.PageObjects;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Tests
{
    internal class PIMTest:Base
    {
        [Test,Order(3)]
        public void AddEmployeeWithoutLoginDetails()
        {
            PIMPage pim = new PIMPage(driver);
            PerformLogin();

            pim.AddEmployeeWithOutLogin("Vinay", "Reddy", "Ramala", "94940");
            Thread.Sleep(2000);

        }

        [Test,Order(4)]
        public void AddEmployeeWithLoginDetails()
        {
            PIMPage pim = new PIMPage(driver);
            PerformLogin();

            pim.AddEmployeeWithLogin("Vinay", "Reddy", "Ramala", "94940", "Vinay", "vinay143");
            Thread.Sleep(3000);

        }
    }
}
