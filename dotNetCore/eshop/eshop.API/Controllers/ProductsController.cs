using eshop.Application;
using eshop.Application.DataTransferObjects.Requests;
using eshop.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eshop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await productService.GetProductsAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await productService.GetProductAsync(id);
            return Ok(product);
        }
        [HttpGet("[action]/{name}")]
        public async Task<IActionResult> SearchProductsByName(string name)
        {
            IEnumerable<Product> products = await productService.GetProductsByNameAsync(name);
            return Ok(products);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Editor")]
        public async Task<IActionResult> CreateNewProduct(CreateNewProductRequest request)
        {
            if (ModelState.IsValid)
            {
                var lastProduct = await productService.CreateNew(request);
                return CreatedAtAction(nameof(GetProduct), new { id = lastProduct }, null);

            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, UpdateProductRequest request)
        {
            if (await productService.IsProductExists(id))
            {
                if (ModelState.IsValid)
                {
                    int updatedProductId = await productService.Update(request);
                    return Ok();
                }
                return BadRequest(ModelState);
            }

            return NotFound(new { message = $"{id} numaralı ürün db'de yok!" });

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (await productService.IsProductExists(id))
            {

                productService.DeleteAsync(id);
                return Ok();
            }

            return NotFound(new { message = $"{id} numaralı ürün db'de yok!" });
        }

    }
}
