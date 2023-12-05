using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using System.Linq.Expressions;


namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
               new Product{ProductId=1, CategoryId=1,ProductName="Bardak", UnitPrice=15,UnitsInStock=15 },
               new Product{ProductId=2, CategoryId=1,ProductName="Kamera", UnitPrice=150,UnitsInStock=10 },
               new Product{ProductId=3, CategoryId=2,ProductName="telefon", UnitPrice=50,UnitsInStock=3 },
               new Product{ProductId=4, CategoryId=2,ProductName="Bilgisayar", UnitPrice=205,UnitsInStock=39 },
               new Product{ProductId=5, CategoryId=2,ProductName="Leptop", UnitPrice=100,UnitsInStock=16 },
               new Product{ProductId=6, CategoryId=1,ProductName="Fare", UnitPrice=30,UnitsInStock=8 }
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //Linq lanquage Integrated Query
            Product productDlete = null;
            foreach(var p in _products)
            {
                if(product.ProductId == p.ProductId)
                {
                    productDlete = p;
                }
            }

            productDlete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
            if(productDlete is not null)
            {
                _products.Remove(productDlete);
            }

            
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
           return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            var categoryList = _products.Where(p=>p.CategoryId == categoryId).ToList(); 
            return categoryList;
        }

        public Product GetProductById(int id)
        {
            var urun = _products.SingleOrDefault(p => p.ProductId == id);
            return urun;
        }

        public List<ProductDetailDTO> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün id si ne sahip olan listedeki ürünü bul
            var urun = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            if(urun is not null)
            {
                urun.ProductName = product.ProductName;
                urun.CategoryId = product.CategoryId;
                urun.UnitPrice = product.UnitPrice;
                urun.UnitsInStock = product.UnitsInStock;

            }
        }
    }
}
