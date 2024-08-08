using OrangeHRM.PageObjects;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Tests
{
    internal class MaintenanceTest:Base
    {
        [Test,Order(7)]
        public void DownloadEmployeeData()
        {
            PerformLogin();
            MaintenancePage maintain = new MaintenancePage(driver);
            maintain.DownloadEmployeeData();
        }
    }
}
