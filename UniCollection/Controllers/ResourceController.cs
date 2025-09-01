using Microsoft.AspNetCore.Mvc;
using SqlSugar;
using UniCollection.Dtos;
using UniCollection.Models;
using UniCollection.Services;

namespace UniCollection.Controllers;


[ApiController]
[Route("[controller]")]
public class ResourceController(ResourceService _resourceService) : ControllerBase
{
    
    [HttpGet(Name = "GetAllResources")]
    public IActionResult GetAll()
    {
        return Ok(_resourceService.GetResources());
    }
    
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(_resourceService.GetResourceById(id));
    }

    [HttpPost]
    public IActionResult Add([FromBody] ResourceDto categoryDto)
    {
        _resourceService.AddResource(categoryDto);
        return Ok();
    }


    [HttpDelete]
    public IActionResult Delete(int id)
    {
        _resourceService.DeleteResourceById(id);
        return Ok();
    }
    
}