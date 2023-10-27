using magazyn_v1.Models;
using magazyn_v1.Models.magazyn_v1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace magazyn_v1.Controllers
{
    public class Orders : Controller
    {
        private static IList<Order> orders = new List<Order>
        {
           new Order { Id = 1, CustomerAdress = "Anieli krzywoń 15, 31-464 Kraków", CustomerEmail = "xyz@gmail.com", CustomerFirstName = "Jan", CustomerLastName = "Kowalski", CustomerPhone = "123 456 678",product = "Laptop", Qty = 10}

        };

        // GET: Orders
        public ActionResult Index()
        {
            return View(orders);
        }

        // GET: Orders/Details/5
        public ActionResult Details(int id)
        {
            return View(orders.FirstOrDefault(x => x.Id == id));
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order order)
        {
            order.Id = orders.Count + 1;
            orders.Add(order);
            return RedirectToAction("Index");
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int id)
        {
            return View(orders.FirstOrDefault(x => x.Id == id));
        }

        // POST: Orders/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Order order)
        {
            Order order1 = orders.FirstOrDefault(x => x.Id == id);
            order1.CustomerFirstName = order.CustomerFirstName;
            order1.CustomerLastName = order.CustomerLastName;
            order1.CustomerEmail = order.CustomerEmail;
            order1.CustomerAdress = order.CustomerAdress;
            order1.CustomerPhone = order.CustomerPhone;
            order1.Qty = order.Qty;
            order1.product = order.product;
            return RedirectToAction("Index");
           
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int id)
        {
            return View(orders.FirstOrDefault(x=>x.Id == id));
        }

        // POST: Orders/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
           Order order1 = orders.FirstOrDefault(x=> x.Id == id);
           orders.Remove(order1);

            return RedirectToAction("Index");
        }
    }
}
