using Ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ajax.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> prodList = new List<Product>();
        // GET: Product
        public ActionResult Index()
        {
            Product p1 = new Product { ProdCode = "P001", ProdName = "Mobile", ProdQty = 75 };
            Product p2 = new Product { ProdCode = "P002", ProdName = "Laptop", ProdQty = 125 };
            Product p3 = new Product { ProdCode = "P003", ProdName = "Netbook", ProdQty = 100 };
            Product p4 = new Product { ProdCode = "P004", ProdName = "Microsoft Surface", ProdQty = 10 };
            Product p5 = new Product { ProdCode = "P005", ProdName = "Microsoft Lumia 1540", ProdQty = 50 };
            prodList.Add(p1);
            prodList.Add(p2);
            prodList.Add(p3);
            prodList.Add(p4);
            prodList.Add(p5);
            return View();
        }

        public PartialViewResult ShowDetails()
        {
            System.Threading.Thread.Sleep(1000);
            string code = Request.Form["txtCode"];
            Product prod = new Product();
            foreach (Product p in prodList)
            {
                if (p.ProdCode == code)
                {
                    prod = p;
                    break;
                }
            }
            return PartialView("_ShowDetails", prod);
        }
    }
}