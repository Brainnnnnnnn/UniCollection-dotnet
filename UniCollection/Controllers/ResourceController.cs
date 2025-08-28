using Microsoft.AspNetCore.Mvc;
using SqlSugar;
using UniCollection.Models;

namespace UniCollection.Controllers;


[ApiController]
[Route("[controller]")]
public class ResourceController(SqlSugarClient _db) : ControllerBase
{
    
    [HttpGet(Name = "GetAllResources")]
    public IActionResult GetAll()
    {
        return Ok(_db.Queryable<Resource>().ToList());
    }
}