using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ValtechTestChallengeRF
{
    [TestClass]
    public class ValtechTest
    {

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }

        [TestMethod]
        public void TestMethod1()
        {
            var driver = GetChromeDriver();

            //#Question 1
            //Wait for page to load for 10 seconds
            driver.Manage().Timeouts().ImplicitWait(10, TimeUnit.SECONDS);
            driver.Navigate().GoToUrl("https://www.valtech.com/");

            IWebElement LatestNewsText = driver.FindElement(By.XPath("//*[@id="container"]/div[2]/div[3]/div[1]/header/h2")).Text;
            //IWebElement element = driver.FindElement(By.TagName("title"));
            Assert.Equals(LatestNewsText, "Latest news");

            //********************************************************************
            //Question 2 

            IWebElement AboutMenu = driver.FindElement(By.XPath("//*[@id="navigationMenuWrapper"]/div/ul/li[1]/a/span"));
            AboutMenu.Click();
            driver.Manage().Timeouts().ImplicitWait(10, TimeUnit.SECONDS);

            IWebElement AboutPageHeader = driver.FindElement(By.XPath("//*[@id="container"]/div[1]/h1")).Text;
            Assert.IsTrue(AboutPageHeader.Text);

            //********************************************************************

            IWebElement WorkMenu = driver.FindElement(By.XPath("//*[@id="navigationMenuWrapper"]/div/ul/li[2]/a/span"));
            WorkMenu.Click();

            driver.Manage().Timeouts().ImplicitWait(10, TimeUnit.SECONDS);
            IWebElement WorkPageHeader = driver.FindElement(By.XPath"//*[@id="container"]/header/h1").Text;
            Assert.IsTrue(WorkPageHeader.Text);

            //********************************************************************

            IWebElement ServicesMenu = driver.FindElement(By.XPath("//*[@id="navigationMenuWrapper"]/div/ul/li[3]/a/span"));
            ServicesMenu.Click();

            driver.Manage().Timeouts().ImplicitWait(10, TimeUnit.SECONDS);
            IWebElement ServicePageHeader = driver.FindElement(By.XPath"//*[@id="container"]/section/header/h1").Text;
            Assert.IsTrue(ServicePageHeader.Text);

            //********************************************************************
            //Question 3
            //Find all countries
            list<string> allCountries = new list<string>();
            IWebElement allCountries = driver.FindElements(By.ClassName("contactcountry"));
            System.Diagnostics.Debug.WriteLine("Total countries: {0}", allCountries);

            //Find all Cities within countries
            list<string> allCities = new list<string>();
            IWebElement allCities = driver.FindElements(By.ClassName("contactcities"));
            System.Diagnostics.Debug.WriteLine("Total cities: {0}", allCities);
        }
    }
}
