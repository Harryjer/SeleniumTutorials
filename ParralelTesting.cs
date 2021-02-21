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
        [Test, Category("UAT testing"), Category("Module1")]
        public void TestMethod1()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            EmailTextField.SendKeys("Selenium c#");
            Driver.Close();
        }
        [Test, Category("UAT testing"), Category("Module1")]
        public void TestMethod2()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            EmailTextField.SendKeys("Selenium c#");
            Driver.Close();
        }
        [Test, Category("UAT testing"), Category("Module1")]
        public void TestMethod3()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            EmailTextField.SendKeys("Selenium c#");
            Driver.Close();
        }
        [Test, Category("UAT testing"), Category("Module1")]
        public void TestMethod4()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            EmailTextField.SendKeys("Selenium c#");
            Driver.Close();
        }
        [Test, Category("UAT testing"), Category("Module1")]
        public void TestMethod5()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            EmailTextField.SendKeys("Selenium c#");
            Driver.Close();
        }
        [Test, Category("UAT testing"), Category("Module1")]
        public void TestMethod6()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            EmailTextField.SendKeys("Selenium c#");
            Driver.Close();
        }
        [Test, Category("UAT testing"), Category("Module1")]
        public void TestMethod7()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            EmailTextField.SendKeys("Selenium c#");
            Driver.Close();
        }
        [Test, Category("UAT testing"), Category("Module1")]
        public void TestMethod8()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            EmailTextField.SendKeys("Selenium c#");
            Driver.Close();
        }
        [Test, Category("UAT testing"), Category("Module1")]
        public void TestMethod9()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            EmailTextField.SendKeys("Selenium c#");
            Driver.Close();
        }
    }
}
