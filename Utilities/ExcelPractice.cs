using Bytescout.Spreadsheet;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Utilities
{
    internal class ExcelPractice:Base
    {
        string FilePath = @"D:\IQTree\Demos\OrangeHRM\UserCredentials.xlsx";
        //Username
        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement username;

        //Password
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement password;

        [Test]
        public void ReadFromExcel()
        {
            
            Spreadsheet document = new Spreadsheet();
            document.LoadFromFile(FilePath);
            Worksheet Credentials = document.Workbook.Worksheets.ByName("Sheet1");
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    TestContext.Progress.WriteLine(Credentials[i, j]);
                }
            }
        }

        //[Test]
        //public void LoginWithExcel()
        //{
        //    Spreadsheet Excel = new Spreadsheet();
        //    Excel.LoadFromFile(FilePath);
        //    Worksheet sheet = Excel.Workbook.Worksheets.ByName("Sheet1");
            
        //}
    }
}
