using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parks.Cores;
using Parks.Cores.Dtos;

namespace Park.API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ParkController : ControllerBase
  {
    private readonly IParkRepository _park;
    private readonly IMapper _mapper;

    public ParkController(IParkRepository park, IMapper mapper)
    {
      _park = park ?? throw new ArgumentNullException(nameof(park));
      _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    /// <summary>
    /// Getting all bands from repositories
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("getband")]
    public async Task<ActionResult<IEnumerable<Parky>>> GetParks()
    {
      var parksFromRepo = await _park.GetParks();
      return Ok(parksFromRepo);
    }


    //[HttpPost]
    //public async Task<IActionResult> CreatePark([FromBody] Parky park)
    //{
    //  if(park == null)
    //    throw new ArgumentNullException(nameof(park));


    //  var parkFromRepo = await _park.AddPark(park);

    //  return Ok(parkFromRepo);
    //}

  }
}

