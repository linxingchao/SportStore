using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportStore.Domain.Abstract;
using SportStore.Domain.Entities;

namespace SportStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        private IProductsRepository resposity;

        public ProductController(IProductsRepository productReposity)
        {
            this.resposity = productReposity;
        }

        public ViewResult List()
        {
            return View(resposity.Products);
        }
    }
}