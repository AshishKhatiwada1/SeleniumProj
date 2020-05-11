using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace firstProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IWebDriver driverChrome = new ChromeDriver();
            driverChrome.Navigate().GoToUrl("https://www.facebook.com/ashish.khatiwada.710");
            driverChrome.FindElement(By.Id("email")).SendKeys("ashish.khatiwada.710");
            driverChrome.FindElement(By.XPath("//input[@id='pass']")).SendKeys("");
            driverChrome.FindElement(By.XPath("//input[@id='pass']")).SendKeys(Keys.Return);

            driverChrome.Navigate().GoToUrl("https://www.facebook.com/ashish.khatiwada.710");
            driverChrome.FindElement(By.ClassName("_1frb")).SendKeys(Keys.Control + "a");
            driverChrome.FindElement(By.ClassName("_1frb")).SendKeys(Keys.Delete);
            driverChrome.FindElement(By.ClassName("_1frb")).SendKeys("suraj subedi");
            driverChrome.FindElement(By.ClassName("_1frb")).SendKeys(Keys.Return);


            //Mozilla Driver
            // IWebDriver driverFirefox = new FirefoxDriver();
            // driverFirefox.Navigate().GoToUrl("https://www.facebook.com");
            // driverFirefox.FindElement(By.Id("email")).SendKeys("ashish.khatiwada.710");
            // driverFirefox.FindElement(By.Id("pass")).SendKeys("");
            // driverFirefox.FindElement(By.Id("pass")).SendKeys(Keys.Return);
            // driverFirefox.Navigate().GoToUrl("https://www.facebook.com/ashish.khatiwada.710");
            // driverFirefox.FindElement(By.ClassName("_1frb")).SendKeys("Asmita Khatiwada");
            // driverFirefox.FindElement(By.ClassName("_1frb")).SendKeys(Keys.Return);

        }
    }
}
