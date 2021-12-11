using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpNet
{
    public class Tests
    {
        public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://aweui.aspnetawesome.com/#Datepicker");
            Driver.FindElement(By.Id("autoc1")).SendKeys("Tomato");
            Driver.FindElement(By.XPath("//div[@class='awe-ajaxcheckboxlist-field awe-field']")).Click();
            Assert.Pass();
        }
    }
}