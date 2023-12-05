using System;


namespace ConsoleDenemesi
{
    
       class Program
        {
            static void Main(string[] args)
            {
                ProductManager productManager = new ProductManager(new EfProductDal());

                foreach (var p in productManager.GetAll())
                {
                    Console.WriteLine(p.ProductName);
                }
            }
        }
    
}
