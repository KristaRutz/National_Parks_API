using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NationalParkDirectoryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace NationalParkDirectoryApi.Controllers
{
  [Route("api/[controller]")]
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
    public ActionResult<IEnumerable<NationalPark>> Get(string name, string alphaCode, string stateCode, string region, string isOpen)
    {
      var queryableParks = _db.NationalParks.AsQueryable();

      if (name != null)
      {
        queryableParks = queryableParks.Where(entry => entry.Name == name);
      }
      if (alphaCode != null)
      {
        queryableParks = queryableParks.Where(entry => entry.AlphaCode == alphaCode);
      }
      if (stateCode != null)
      {
        queryableParks = queryableParks.Where(entry => entry.StateCode == stateCode);
      }
      if (region != null)
      {
        queryableParks = queryableParks.Where(entry => entry.Region == region);
      }
      if (isOpen != null)
      {
        if (isOpen == "true" || isOpen == "1")
        {
          queryableParks = queryableParks.Where(entry => entry.IsOpen == true);
        }
        else if (isOpen == "false" || isOpen == "0")
        {
          queryableParks = queryableParks.Where(entry => entry.IsOpen == false);
        }
      }

      return queryableParks.ToList();
    }

    // GET api/nationalparks/5
    [HttpGet("{id}")]
    public ActionResult<NationalPark> Get(int id)
    {
      return _db.NationalParks.FirstOrDefault(entry => entry.NationalParkId == id);
    }

    // POST api/nationalparks
    [HttpPost]
    public void Post([FromBody] NationalPark park)
    {
      _db.NationalParks.Add(park);
      _db.SaveChanges();
    }

    // PUT api/nationalparks/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] NationalPark park)
    {
      park.NationalParkId = id;
      _db.Entry(park).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/nationalparks/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var parkToDelete = _db.NationalParks.FirstOrDefault(entry => entry.NationalParkId == id);
      _db.NationalParks.Remove(parkToDelete);
      _db.SaveChanges();
    }
  }
}
