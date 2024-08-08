using OrangeHRM.PageObjects;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Tests
{
    internal class RecruitmentTest:Base
    {
        [Test,Order(6)]
        public void AddVacancy()
        {
            string Description = "We’re looking for a software developer to join our development team working on developing our core products. You’ll work with a manager and software development team on several features of our products and be involved in the concept-to-delivery of high-quality solutions.";
            RecruitmentPage Recruitment = new RecruitmentPage(driver);
            PerformLogin();
            Recruitment.AddVacancy("DotNet Developer", "5", Description);
            Thread.Sleep(4000);

        }
    }
}
