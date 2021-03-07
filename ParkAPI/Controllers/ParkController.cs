using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parks.Cores;

namespace Park.API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ParkController : ControllerBase
  {
    private readonly IParkRepository _park;

    public ParkController(IParkRepository park)
    {
      _park = park;
    }

    /// <summary>
    /// Getting all bands from repositories
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("getbands")]
    public IActionResult GetBands()
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Getting specific BandId
    /// </summary>
    /// <param name="bandId"></param>
    /// <returns></returns>
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult GetBand()
    {
      var bandFromRepo = _park.GetBand();

      return Ok(bandFromRepo);
    }
  }
}
