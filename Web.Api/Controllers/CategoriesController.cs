using Business.Abstract;
using Entities.DTOs.Category;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(CategoryAddDto categoryAddDto)
        {
            var result = this._categoryService.IsExists(categoryAddDto.CategoryName);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }


            _categoryService.Add(categoryAddDto);

            return new JsonResult(categoryAddDto);

        }

    }
}
