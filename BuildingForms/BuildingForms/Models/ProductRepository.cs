using System;
namespace BuildingForms.Models
{
	public static class ProductRepository
	{
		private static List<Product> _products;
		public static List<Product> Products {
			get {
				return _products;
			}
		}
		static ProductRepository(){
			_products = new List<Product>() {
				new Product(){Id = 1, Description = "1Desc", isApproved = false,Name = "1nsame", Price = 9999},
				new Product(){Id = 2, Description = "2Desc", isApproved = false,Name = "2nsame", Price = 9999},
				new Product(){Id = 3, Description = "3Desc", isApproved = false,Name = "3nsame", Price = 9999},
				new Product(){Id = 4, Description = "4Desc", isApproved = false,Name = "4nsame", Price = 9999},
				new Product(){Id = 5, Description = "5Desc", isApproved = false,Name = "5nsame", Price = 9999}
			};	
		}
		public static void AddProduct(Product product) {
			_products.Add(product);
		}
	}
}

