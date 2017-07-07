using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace ConsoleApp1
{
    class FirstTestCase
    {
        static void Main(string[] args)
        {            
            IWebDriver driver = new ChromeDriver(@"D:\Drivers");
            driver.Url = "http://www.demoqa.com";
        }
    }
}
