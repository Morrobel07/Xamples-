

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
            object[] data = new object[]{

               275M,29.25M, "apple","oranfe",100,10
            };
            decimal total = 0;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] is decimal d)
                {
                    total += d;
                }



            }

            return View("Index", new string[] { $"Total: {total:C2}" });





        }


    }
}