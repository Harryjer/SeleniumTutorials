// NUnit 3 tests

using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTutorials.BaseClass;
using System.Threading;

namespace SeleniumTutorials
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            // TODO: Add your test code here
            
            
            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            EmailTextField.SendKeys("Selenium c#");
            
        }

        [Test]
        public void TestMethod2()
        {
            // TODO: Add your test code here


            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            EmailTextField.SendKeys("Selenium c#");

        }

        [Test]
        public void TestMethod3()
        {
            // TODO: Add your test code here


            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            EmailTextField.SendKeys("Selenium c#");
            Thread.Sleep(3000);

        }



    }
}
