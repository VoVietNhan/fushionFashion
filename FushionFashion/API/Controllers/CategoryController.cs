using Application.Interface;
using Application.ViewModel.CategoryViewModel;
using Application.ViewModel.ProductViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost("CreateProduct")]
        public async Task<ActionResult<CreateCategoryViewModel>> CreateProduct(CreateCategoryViewModel categoryViewModel)
        {
            if (ModelState.IsValid)
            {

                await _categoryService.CreateCategory(categoryViewModel);

                return Ok("Created a new product successfully.");

            }

            return BadRequest("Invalid input or validation failed.");
        }

       
    }
}
