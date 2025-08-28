using Microsoft.AspNetCore.Mvc;
using SqlSugar;
using UniCollection.Models;

namespace UniCollection.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController(ISqlSugarClient _db) : ControllerBase
{
    [HttpGet(Name = "GetAllCategorys")]
    public IActionResult GetAll()
    {
        return Ok(_db.Queryable<Category>().ToList());
    }
}