
using System.Collections.Generic;
using Blogger.Models;
using Blogger.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blogger.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BlogsController : ControllerBase
  {
    private readonly BlogsService _bs;
    public BlogsController(BlogsService bs)
    {
      _bs = bs;
    }
    [HttpGet]
    public ActionResult<List<Blog>> GetAll()
    {
      try
      {
           return Ok(_bs.GetAll());
      }
      catch (System.Exception e)
      {
          return BadRequest(e.Message);
      }
    }
  }
}