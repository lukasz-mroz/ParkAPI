using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Park.API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ParkController : ControllerBase
  {

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
    [HttpGet("{bandId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult GetBand(Guid bandId)
    {
      if(bandId == null)
        throw new ArgumentNullException(nameof(bandId));



      return Ok(bandId);
    }
  }
}
