using Microsoft.AspNetCore.Mvc;
using WebApi.Blog.Services;

namespace WebApi.Blog.Controllers;

[ApiController]
[Route("[controller]")]
public class BlogController : Controller
{
    private readonly IBlogService _service;

    public BlogController(IBlogService service)
    {
        _service = service;
    }

    [HttpPost]
    [Route("insert")]
    public IActionResult InsertOne(Entities.Blog blog)
    {
         _service.Insert(blog);
        return Ok();
    }
    
    [HttpGet]
    [Route("{id:int}")]
    public IActionResult GetById([FromRoute]int id)
    {
       var result =  _service.GetById(id);
       return result != null ? Json(result) : NotFound();
    }
}