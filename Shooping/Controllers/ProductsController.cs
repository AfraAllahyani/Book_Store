using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shooping.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shooping.Controllers
{
    public class ProductsController : Controller
    {
        public List<ProductModel> Products = new List<ProductModel>() {
        new ProductModel() { id = 1, Name = "item1", Price = 30.4f, img = "https://d1csarkz8obe9u.cloudfront.net/posterpreviews/action-thriller-book-cover-design-template-3675ae3e3ac7ee095fc793ab61b812cc_screen.jpg?ts=1588152105" },
        new ProductModel() { id = 2, Name = "item2", Price = 100.0f, img = "https://www.designforwriters.com/wp-content/uploads/2017/10/design-for-writers-book-cover-tf-2-a-million-to-one.jpg" },
        new ProductModel() { id = 3, Name = "item3", Price = 480.0f, img = "https://d1csarkz8obe9u.cloudfront.net/posterpreviews/contemporary-fiction-night-time-book-cover-design-template-1be47835c3058eb42211574e0c4ed8bf_screen.jpg?ts=1594616847" },
        new ProductModel() { id = 4, Name = "item4", Price = 230.2f, img = "https://templiit.com/wp-content/uploads/2020/10/1572247795725_novel-5.jpg" },
        new ProductModel() { id = 5, Name = "item5", Price = 70.2f, img = "https://i.pinimg.com/originals/7e/ba/a5/7ebaa52b760ebab4650ee75131bcf543.png" },
        new ProductModel() { id = 6, Name = "item6", Price = 40.2f, img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1501811376l/33413955.jpg" },
        new ProductModel() { id = 7, Name = "item7", Price = 130.2f, img = "https://images.gr-assets.com/books/1490977482l/34742968.jpg" },
        new ProductModel() { id = 8, Name = "item8", Price = 60.2f, img = "https://marketplace.canva.com/EAD7WuSVrt0/1/0/251w/canva-colorful-illustration-young-adult-book-cover-_jUQ_Pi-Kvg.jpg" },
     };
        // GET: /products/
        public IActionResult Index(string color="white")
        {
            ViewData["color"] = color;
            ViewData["products"] = Products;
            return View();
        }
        // GET: /Details/
        public IActionResult Details(int? id)// when the URL is (https://localhost:5001/products/details) it will return Sorry inside the if statment becuse the id equal null.

        {
            ProductModel product = Products.Find(b => b.id == id);
            if (product == null)
            {
                return Content("Sorry .. book you are looking for is not available.");
            }
            else
            {
                ViewData["product"] = product;
                return View();
            }
        }



    }
}