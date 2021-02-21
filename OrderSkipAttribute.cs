// NUnit 3 tests

using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTutorials.BaseClass;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SeleniumTutorials
{
    [TestFixture]
    public class OrderSkipAttribute
    { 

        [Test, Order(2), Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            Assert.Ignore("Defect 12345");
            IWebDriver driver=new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            EmailTextField.SendKeys("Selenium c#");
            driver.Close();
        }

        [Test, Order(1), Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            EmailTextField.SendKeys("Selenium c#");
            driver.Close();
        }

        [Test, Order(0), Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            EmailTextField.SendKeys("Selenium c#");
            driver.Close();
        }


    }



}

