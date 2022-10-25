using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using NUnit.Framework;
namespace HPS
{
    class HPSS
    {
        //create the reference for the browser  
        IWebDriver driver = new ChromeDriver();
        [SetUp]
        public void Initialize()
        {
            //navigate to URL  
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("u_0_15_v6")).Click();
            Thread.Sleep(2000);
            //Maximize the browser window  
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);


            
        }
        [Test]
        public void ExecuteTest()
        {
            

            //identify the google search button  
            IWebElement fb1 = driver.FindElement(By.Id("u_0_15_v6"));

            // click on the Google search button  
            fb1.Click();
            Thread.Sleep(3000);

            //identify the username text box  
            IWebElement ele = driver.FindElement(By.Id("email"));
            //enter the username value  
            ele.SendKeys("jairen.maddix@minutestep.com");
            Thread.Sleep(2000);
            Console.Write("username value is entered \n");
            //identify the password text box  
            IWebElement ele1 = driver.FindElement(By.Name("passContainer"));
            //enter the password value  
            ele1.SendKeys("Leptir031");
            Console.Write("password is entered \n");
            //click on the Login button  
            IWebElement ele2 = driver.FindElement(By.Id("u_0_5_cj"));
            ele2.Click();
            Thread.Sleep(3000);
            Console.Write("login button is clicked \n");
        }
        [TearDown]
        public void EndTest()
        {
            //close the browser  
            driver.Close();
        }
    }
}