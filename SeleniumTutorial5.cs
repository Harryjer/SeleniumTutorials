using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace SeleniumTutorials
{
    [TestFixture]
    public class SeleniumTutorial5
    {
        ExtentReports extent = null;
        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"F:\QA\Selenium Training\SeleniumTutorials\Demo5.html");
            extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = null;
            ExtentTest test = null;
            try
            {
                test = extent.CreateTest("Test1").Info("Test Started");
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                test.Log(Status.Info,"Chrome browser launched");
                driver.Url = "https://www.facebook.com/";

                IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
                EmailTextField.SendKeys("Selenium c#");
                test.Log(Status.Info, "Email ID confirmed");
                test.Log(Status.Pass,"Test is passed");
                driver.Quit();
                test.Log(Status.Pass, "Driver is closed");
            }
            catch (Exception e)
            {

                throw;

            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }

        }
    }
}
