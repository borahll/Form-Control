using System;
using BuildingForms.Models;
using Microsoft.AspNetCore.Mvc;

namespace BuildingForms.Controllers
{
	public class Home:Controller{
        [HttpGet]
        public IActionResult Index()
		{
			return View(ProductRepository.Products);
		}
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product p)
        {
            ProductRepository.AddProduct(p);
            return RedirectToAction(actionName:"Index", controllerName: "Home");
        }
        [HttpGet]
        public IActionResult Search(string q)
        {
            if (string.IsNullOrWhiteSpace(q)) {
                return View();
            }
            return View("Index", ProductRepository.Products.Where(i=>i.Name.Contains(q)));
        }
    }
}

