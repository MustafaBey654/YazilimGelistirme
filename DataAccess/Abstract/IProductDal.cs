using Core.DataAccess;
using Entities.Concreate;
using Entities.DTOs;


namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDTO> GetProductDetails();
    }
}
