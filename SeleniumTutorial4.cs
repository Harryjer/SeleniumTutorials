using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTutorials
{
    public class SeleniumTutorial4
    {
        [Test]
        [Author("Thisal", "thisal@quadrate.lk")]
        [Description("Facebook login verified")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(String urlName)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://www.facebook.com/";
                driver.Url = urlName;
                //IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
                //EmailTextField.SendKeys("Selenium c#");
                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot ts =  driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("F:\\QA\\Selenium Training\\SeleniumTutorials\\screenshot.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;

            }
            finally
            {
                if(driver!= null)
                {
                    driver.Quit();
                }
            }
           
        }

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/");
            list.Add("https://www.youtube.com/");
            list.Add("https://www.gmail.com/");
            return list;
        }

/*
        [Test]
        [Author("Thisal", "thisal@quadrate.lk")]
        [Description("Facebook login verified")]
        public void Test2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
            IWebElement EmailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            EmailTextField.SendKeys("Selenium c#");
            driver.Quit();
        }*/
    }
}
