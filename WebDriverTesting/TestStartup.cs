using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebDriverTesting
{
    [TestFixture]
    public class TestStartup
    {
        [TestCase]
        public void Execute()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Url = @"http://google.com";
            Thread.Sleep(3000);
            webDriver.Close();
        }
    }
}
