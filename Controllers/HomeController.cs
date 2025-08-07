

using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Models;
using System.Collections.Generic;



namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //Product[]? products = Product.GetProducts();

            // return View(new string[] { products?[0].Name ?? "No products available" });
            // return View(new string[] { products?[0]!.Name });

            //     return View(new string[]{
            //     $"Name:{products?[0]?.Name}, Price:{products?[0]?.Price:C2}"
            //    });
            //
            // Dictionary<string, Product> products = new ()

            // {
            //     ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
            //     ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
            // };
            // return View("Index", products.Keys);
            // object[] data = new object[] {

            //     275M,29.25M, "apple","oranfe",100,10
            //  };
            // decimal total = 0;

            // for (int i = 0; i < data.Length; i++)
            // {
            //     if (data[i] is decimal d)
            //     {
            //         total += d;
            //     }



            // }

            // return View("Index", new string[] { $"Total: {total:C2}" });

            //for (var i = 0; i < data.Length; i++)
            // {
            //     switch (data[i]) {
            //         case decimal decimalValue:
            //             total += decimalValue;
            //             break;
            //         case int intValue when intValue > 50:
            //             total += intValue;
            //             break;

            //     }



            // }
            // return View("Index", new string[] { $"Total:{total:C2}" });

            // ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

            // decimal cartTotal = cart.TotalPricess();

            // return View("Index", new string[] { $"Total : {cartTotal:C2}" });

            ShoppingCart cart =
            new ShoppingCart { Products = Product.GetProducts() };

            Product[] productArray = {
                new Product { Name = "Kayac",Price = 275M},
                new Product { Name="Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };

            //decimal cartTotal = cart.TotalPrices();
            decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();

            return View("Index", new string[] {
                //$"Cart Total:{cartTotal:C2}",
                $"Array Total:{arrayTotal:C2}"
            });
        }

        public IActionResult Viewuno()
        {
            // string[] nombresArray = { "Juan", "Ana", "Pedro", "Maria" };
            // Nombres nombres = new Nombres(nombresArray);

            // var listaNombres = new List<string>();
            // foreach (var nombre in nombres)
            // {
            //     listaNombres.Add(nombre);
            // }

            // ViewBag.ListaNombres = listaNombres;
            // return View(listaNombres);
            // Simplificamos para probar
            var listaNombres = new List<string> { "Juan", "Ana", "Pedro", "Maria" };
            return View(listaNombres);
        }

        public IActionResult Pares()
        {
            NumerosPares numerospares = new NumerosPares(20);
            return View(numerospares);
        }
    }
}
