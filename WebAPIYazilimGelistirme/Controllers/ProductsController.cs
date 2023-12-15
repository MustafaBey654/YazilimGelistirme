using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIYazilimGelistirme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getAll")]
        public IActionResult Get()
        {

            var result = _productService.GetAll();
            if (result.Data == null)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }

        }

        [HttpPost("AddProduct")]
        public IActionResult AddProduct(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("{GetById}")]

        public IActionResult GetProductId([FromRoute(Name ="id")] int id)
        {
            var result = _productService.GetById(id);

            if(result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteProductId([FromRoute(Name ="id")]int id)
        {
            var result = _productService.DeleteById(id);
            if (result.Success)
            {
                return Ok(result.Success);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
