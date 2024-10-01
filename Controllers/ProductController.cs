using Microsoft.AspNetCore.Mvc;

public class ProductController : Controller
{
  public List<Product> Products = new List<Product> {
    new Product(){ Id = 1, Name="Fishing Pole", Price = 1.99 },
    new Product(){ Id = 2, Name="Kite String", Price = 2.99 },
    new Product(){ Id = 3, Name="Silly Putty", Price = 3.99 }
  };
  public IActionResult Index() => View(Products);
}
