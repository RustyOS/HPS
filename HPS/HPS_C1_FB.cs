using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using NUnit.Framework;

namespace HPS
{
    class HPSFB
    {
        //Postavke za Chrome/Driver
        
        IWebDriver driver = new ChromeDriver();
        [SetUp]
       
        
        public void Initialize()
        {
       
       
        //Funkcija koja otvara facebook stranicu  
        driver.Navigate().GoToUrl("https://www.facebook.com/");

            
        //Postavljamo preglednik u punu rezoluciju 
         driver.Manage().Window.Maximize();
         
         //Pauza
         Thread.Sleep(2000);


            
        }
        [Test]
        public void ExecuteTest()
        {
            // Funkcija koja odobrava kolačiće
            driver.FindElement(By.XPath("//button[@title= 'Allow essential and optional cookies']")).Click();
           
            //Pauza
            Thread.Sleep(3000);

            //Pronalazak forme za login (UserName)
            IWebElement ele = driver.FindElement(By.Id("email"));
           
            //Unos Username
            ele.SendKeys("jairen.maddix@minutestep.com");
            Thread.Sleep(2000);
            Console.Write("username value is entered \n");

            //Pronalazak forme za login (Password)
            IWebElement ele1 = driver.FindElement(By.Name("pass"));

            //Unos Password
            ele1.SendKeys("Leptir031");
            Console.Write("password is entered \n");
         
            //click on the Login button 
            driver.FindElement(By.XPath("//button[@name= 'login']")).Click();
            Thread.Sleep(3000);
            Console.Write("login button is clicked \n");
        }
        [TearDown]
        public void EndTest()
        {
            //Pauza
            Thread.Sleep(9000);

            //Zatvaranje Chrome
            driver.Close();
        }
    }
}