using Microsoft.AspNetCore.Mvc;
using SqlSugar;
using UniCollection.Dtos;
using UniCollection.Models;
using UniCollection.Services;

namespace UniCollection.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController(CategoryService _categoryService) : ControllerBase
{
    [HttpGet(Name = "GetAllCategorys")]
    public IActionResult GetAll()
    {
        return Ok(_categoryService.GetCategories());
    }


    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(_categoryService.GetCategoryById(id));
    }

    [HttpPost]
    public IActionResult Add([FromBody] CategoryDto categoryDto)
    {
        _categoryService.AddCategory(categoryDto);
        return Ok();
    }


    [HttpDelete]
    public IActionResult Delete(int id)
    {
        _categoryService.DeleteCategoryById(id);
        return Ok();
    }

}