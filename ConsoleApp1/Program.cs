// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using ConsoleApp1.Deneme;
using ConsoleApp1.Deneme.Concrete;
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

var result = productManagers.GetProductDetails();
if(result.Success==true)
{
	foreach (var product in result.Data)
	{
        Console.WriteLine(product.ProductName + "=>" + product.ProductId + "=>" + product.CategoryName); ;
    }
}
else
{
    Console.WriteLine(result.Message);
}

Console.WriteLine("*/*/*/*/*/*/*/*/");

var customer = new Customer { Id = 1, Name = "mustafa", LastName = "yılmaz", Adress = "hacı bayram mah." };
var employee = new Employee { Id = 2, Name = "İşçi ", LastName = "kardeş" };

PersonManager personManager = new PersonManager();
personManager.Add(customer);
personManager.Add(employee);