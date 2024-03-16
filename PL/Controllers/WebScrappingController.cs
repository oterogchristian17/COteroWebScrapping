using Microsoft.AspNetCore.Mvc;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace PL.Controllers
{
    public class WebScrappingController : Controller
    {
        public IActionResult MLSearch()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Url = "https://www.mercadolibre.com.mx/";

            IWebElement element = driver.FindElement(By.ClassName("nav-search-input"));
            element.SendKeys("Petacas Miguel");

            IWebElement resultsPanel = driver.FindElement(By.ClassName("nav-icon-search"));
            resultsPanel.Click();

          

            IWebElement nameProduct = driver.FindElement(By.ClassName("ui-search-item__brand-discoverability ui-search-item__group__element"));

            Console.WriteLine($"Name: {nameProduct}");

            //var products = new List<Product>();

            //var nameElement = driver.FindElement(By.XPath("//div[@class='ui - search - item__title']"));


            //var name = nameElement.Text;

            //var product = new Product { Nombre = name };

            //products.Add(product);



            //foreach (var productElement in productElements)
            //{
            //    // select the name and price elements
            //    var nameElement = productElement.FindElement(By.ClassName("ui - search - item__title"));
            //    var priceElement = productElement.FindElement(By.ClassName("andes-money-amount__fraction"));

            //    // extract their data
            //    var name = nameElement.Text;
            //    var price = priceElement.Text;

            //    // create a new product object and add it to the list
            //    var product = new Product { Nombre = name, Costo = price };

            //    products.Add(product);
            //}

            return View();

        }
    }
}
