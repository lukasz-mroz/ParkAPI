using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;
using Parks.Cores;

namespace Park.API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ParkController : ControllerBase
  {
    private readonly IMapper _mapper;
    private readonly IHttpClientFactory _client;
    //private readonly ILogger _logger;
    private readonly IParkRepository _repository;


    public ParkController(IParkRepository repository, IMapper mapper, 
      IHttpClientFactory client)
    {
      _repository = repository ?? throw new ArgumentNullException(nameof(repository));
      _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
      _client = client ?? throw new ArgumentNullException(nameof(client));
      //_logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    /// <summary>
    /// Getting all bands
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("getband")]
    [ResponseCache(Duration = 60)]
    public async Task<ActionResult<IEnumerable<Parky>>> GetParks()
    {
      try
      {
        var parksFromRepo = await _repository.GetAllParks(Guid.Parse("F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E4"));
        return Ok(parksFromRepo);
      }
      catch (Exception e)
      {
        //_logger.LogError($"Something went wrong in the {nameof(GetParks)} action {e}");
        return StatusCode(500, "Internal server error");
      }

    }


  }


}


