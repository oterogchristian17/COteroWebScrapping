using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace IntroSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Url = "https://www.mercadolibre.com.mx/";

            IWebElement element = driver.FindElement(By.ClassName("nav-search-input"));
            element.SendKeys("Petacas Miguel");

            IWebElement resultsPanel = driver.FindElement(By.ClassName("nav-icon-search"));
            resultsPanel.Click();
        }
    }
}
