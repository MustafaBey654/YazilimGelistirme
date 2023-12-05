// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

Console.WriteLine("Hello, World!");
//ProductManagers productManagers = new ProductManagers(new EfProductDal());

//foreach(var p in productManagers.GetByUnitPrice(50,100))
//{
//    Console.WriteLine(p.ProductName);
//}
//Console.WriteLine("Hello, World!");

//CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
//foreach(var c in categoryManager.GetAll())
//{
//    Console.WriteLine(c.CategoryName,c.CategoryId);
//}

ProductManagers productManagers = new ProductManagers(new EfProductDal());

foreach(var p in productManagers.GetProductDetails())
{
    Console.WriteLine(p.ProductName + " / "+ p.CategoryName);
}

