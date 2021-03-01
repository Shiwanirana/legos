using System;
using System.Collections.Generic;
using Legos.Models;
using Legos.Services;
using Microsoft.AspNetCore.Mvc;
namespace Legos.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BricksController : ControllerBase
  {
    private readonly BricksService _bs;
    [HttpGet]
    public ActionResult<IEnumerable<Brick>> Get()
    {
      try{
      return Ok(_bs.Get());
     }
     catch(Exception e)
     {
       return BadRequest(e.Message);
     }
    }
  }
}