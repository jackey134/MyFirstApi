using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Models;

namespace MyFirstApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "iPhone", Price = 30000, Stock = 10, IsAvailable = true },
                new Product { Id = 2, Name = "iPad", Price = 20000, Stock = 5, IsAvailable = true },
                new Product { Id = 3, Name = "MacBook", Price = 50000, Stock = 0, IsAvailable = false }
            };
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = new Product
            {
                Id = id,
                Name = "iPhone",
                Price = 30000,
                Stock = 10,
                IsAvailable = true
            };
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Product product)
        {
            return Ok(new { Message = $"成功建立商品：{product.Name}" });
        }
    }
}