using Application.Interface;
using Application.ViewModel.ProductViewModel;
using Domain.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("GetAllProduct")]
        public async Task<ActionResult<ProductViewModel>> GetAllProduct()
        {
            var product = await _productService.GetProduct();

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpGet("GetProductById/{id}")]
        public async Task<ActionResult<ProductViewModel>> GetProductById(Guid id)
        {
            var product = await _productService.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost("CreateProduct")]
        public async Task<ActionResult<CreateProductViewModel>> CreateProduct(CreateProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {

                await _productService.CreateProduct(productViewModel);

                return Ok("Created a new product successfully.");

            }

            return BadRequest("Invalid input or validation failed.");
        }

        [HttpPut("UpdateProduct/{id}")]
        public async Task<ActionResult<UpdateProductViewModel>> UpdateProduct(Guid id, UpdateProductViewModel productDTO)
        {
            if (ModelState.IsValid)
            {
                var updatedProduct = await _productService.UpdateProduct(id, productDTO);

                if (updatedProduct != null)
                {
                    return Ok("Update Product Success");
                }
                else
                {
                    return NotFound("Product with the specified ID not found");
                }
            }
            return BadRequest("Invalid Model State");
        }

    }
}
