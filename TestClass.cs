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
        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {
            // TODO: Add your test code here
            
            
            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            EmailTextField.SendKeys("Selenium c#");
            
        }

        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            // TODO: Add your test code here


            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            EmailTextField.SendKeys("Selenium c#");

        }

        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            // TODO: Add your test code here


            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            EmailTextField.SendKeys("Selenium c#");
            driver.FindElement(By.CssSelector("#u_0_2_6V"));
            
            Thread.Sleep(3000);

        }



    }
}
