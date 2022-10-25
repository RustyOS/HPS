using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
namespace HPS
{
    class HPSG
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            // Zapis u konzolu početak testiranja
            Console.Write("test case started ");

            //Postavke za Chrome Driver
            IWebDriver driver = new ChromeDriver();
           
            // Navigiranje na Google Stranicu  
            driver.Navigate().GoToUrl("https://www.google.com/");
            
            //Pauza
            Thread.Sleep(2000);

            //Potvrda korištenja google usluge
            IWebElement ele1 = driver.FindElement(By.Id("L2AGLb"));
            ele1.Click();

            // Pauza
            Thread.Sleep(3000);

            //Navigacija u formu
            IWebElement ele = driver.FindElement(By.Name("q"));

            //Unos u formu Google Tražilice  
            ele.SendKeys("javatpoint tutorials");
            Thread.Sleep(2000);
          
            //Potvrda unosa
            IWebElement ele2 = driver.FindElement(By.Name("btnK"));
            ele2.Click();

            //Pauza
            Thread.Sleep(3000);
            
            //Izlaz
            driver.Close();
            Console.Write("test case ended ");
        }
    }
}