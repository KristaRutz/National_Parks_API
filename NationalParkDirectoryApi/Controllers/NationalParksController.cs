using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NationalParkDirectoryApi.Models;

namespace NationalParkDirectoryApi.Controllers
{
  [Route("api/1.0/[controller]")]
  [ApiController]
  public class NationalParksController : ControllerBase
  {
    private NationalParkDirectoryApiContext _db;
    public NationalParksController(NationalParkDirectoryApiContext db)
    {
      _db = db;
    }

    // GET api/nationalparks
    [HttpGet]
    public ActionResult<IEnumerable<NationalPark>> Get()
    {
      return _db.NationalParks.ToList();
    }

    // // GET api/nationalparks/5
    // [HttpGet("{id}")]
    // public ActionResult<string> Get(int id)
    // {
    //   return "value";
    // }

    // POST api/nationalparks
    [HttpPost]
    public void Post([FromBody] NationalPark park)
    {
      _db.NationalParks.Add(park);
      _db.SaveChanges();
    }

    // // PUT api/values/5
    // [HttpPut("{id}")]
    // public void Put(int id, [FromBody] string value)
    // {
    // }

    // // DELETE api/values/5
    // [HttpDelete("{id}")]
    // public void Delete(int id)
    // {
    // }
  }
}
