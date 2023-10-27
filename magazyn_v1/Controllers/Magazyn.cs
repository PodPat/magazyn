using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using magazyn_v1.Models;
namespace magazyn_v1.Controllers
{
    public class Magazyn : Controller
    {
        private static IList<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Printer", Producer = "Sony", Qty = 10}

        };
        // GET: HomeController1
        public ActionResult Index()
        {
            return View(products);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            return View(products.FirstOrDefault(x => x.Id == id));
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
            return RedirectToAction("Index");


        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View(products.FirstOrDefault(x => x.Id == id));
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            Product product1 = products.FirstOrDefault(x => x.Id == id);
            product1.Name = product.Name;
            product1.Producer = product.Producer;
            product1.Qty = product.Qty;
            return RedirectToAction("Index");
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View(products.FirstOrDefault(x => x.Id == id));
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            Product product1 = products.FirstOrDefault(x => x.Id == id);
            products.Remove(product1);

            return RedirectToAction("Index");
        }
    }
}

