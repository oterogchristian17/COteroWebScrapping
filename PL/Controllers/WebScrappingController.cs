using Microsoft.AspNetCore.Mvc;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using static System.Collections.Specialized.BitVector32;
using DL;

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


            List<string> misProductos = new List<string>();  
            
            foreach(var Nodo in driver.Url.Cast)



            //   string productos = driver.FindElement(By.ClassName("ui-search"));

            //       pokemons = driver.find_elements(By.XPATH, "//*[@id='main']/ul/li")

            //       //*[@id="root-app"]
  

            
                var productos = driver.FindElements(By.XPath("//h2[@class='ui-search-item__title']"));

                Console.WriteLine(productos);
            

      
                //   }

                //    for pokemon in pokemons:

                //name = pokemon.find_element(By.XPATH, ".//h2").text

                //price = pokemon.find_element(By.XPATH, ".//span").text

                //img = pokemon.find_element(By.XPATH, ".//img").get_attribute("src")

                //link = pokemon.find_element(By.XPATH, ".//a").get_attribute("href")

                //*[@id=":Rgl9bb:"]
                //*[@id="main"]/ul/li[3]
                // Console.WriteLine(precio);

                //IWebElement nameProduct = driver.FindElement(By.ClassName("ui-search-item__brand-discoverability ui-search-item__group__element"));

                //Console.WriteLine($"Name: {nameProduct}");

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
