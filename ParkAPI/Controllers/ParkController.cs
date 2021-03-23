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
using Parks.Cores.Dtos;

namespace Park.API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ParkController : ControllerBase
  {
    private readonly IParkRepository _park;
    private readonly IMapper _mapper;
    private readonly IHttpClientFactory _client;
    private readonly ILogger _logger;


    public ParkController(IParkRepository park, IMapper mapper, 
      IHttpClientFactory client, ILogger logger)
    {
      _park = park ?? throw new ArgumentNullException(nameof(park));
      _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
      _client = client ?? throw new ArgumentNullException(nameof(client));
      _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    /// <summary>
    /// Getting all bands from repositories
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("getband")]
    [ResponseCache(Duration = 60)]
    public async Task<ActionResult<IEnumerable<Parky>>> GetParks()
    {
      var parksFromRepo = await _park.GetParks();

      return Ok(parksFromRepo);
    }

    /// <summary>
    /// Getting something from external API
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<string> GetFromApi()

    {
      var client = _client.CreateClient();

      client.BaseAddress =
        new Uri("https://api.exchangeratesapi.io");
      client.DefaultRequestHeaders.Add(
        HeaderNames.UserAgent, "ExchangeRateViewer");

      var response = await client.GetAsync("latest");

      response.EnsureSuccessStatusCode();

      return await response.Content.ReadAsStringAsync();
    }
    /// <summary>
    /// Creating a new Park
    /// </summary>
    /// <param name="park"></param>
    /// <returns></returns>
    [HttpPost]
    public ActionResult<ParkyDto> CreatePark([FromBody] ParkForCreatingDto park)
    {

      var parkEntity = _mapper.Map<Parky>(park);
      _park.AddPark(parkEntity);

      if (park == null)
      {
        _logger.LogError($"Something went wrong in the {nameof(CreatePark)} action");
        return BadRequest("ParkForCreatingDto is null");
      }


      throw new NotImplementedException("errr");

    }

  }


}


