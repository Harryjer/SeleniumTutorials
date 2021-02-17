using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumTutorials.BaseClass;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using SeleniumTutorials.Utilities;

namespace SeleniumTutorials
{
    [TestFixture]
    public class ParralelTesting
    {
        IWebDriver driver;
        // TODO: Add your test code here
        [Test, Category("UAT testing"), Category("Module")]
        public void TestMethod1()
        {
            new BrowserUtility().Init(driver);
            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            EmailTextField.SendKeys("Selenium c#");
        }  
        
    }
}
