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
    /// Getting all parks
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("getparks")]
    [ResponseCache(Duration = 60)]
    public async Task<ActionResult<IEnumerable<Parky>>> GetParks()
    {
      try
      {
        var parksFromRepo = await _repository.GetAllParks();
        return Ok(parksFromRepo);
      }
      catch (Exception e)
      {
        //_logger.LogError($"Something went wrong in the {nameof(GetParks)} action {e}");
        return StatusCode(500, "Internal server error");
      }

    }
    /// <summary>
    /// Get one band
    /// </summary>
    /// <param name="parkId"></param>
    /// <returns></returns>
    [HttpGet("{parkId}", Name = "GetPark") ]
    [ResponseCache(Duration = 60)]
    public async Task<ActionResult<Parky>> GetPark(Guid parkId)
    {
        var parkFromRepo = await _repository.GetPark(parkId);
        return Ok(parkFromRepo);
    
    }

    /// <summary>
    /// Create a new park
    /// </summary>
    /// <param name="park"></param>
    [HttpPost]
    [Route("createpark")]
    public void CreatePark(Parky park)
      {
      // TODO rewrite using DTOs
      _repository.CreatePark(park);
      _repository.Save();
    }


  }


}


