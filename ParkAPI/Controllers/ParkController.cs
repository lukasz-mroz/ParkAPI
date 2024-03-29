﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
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
    private readonly ILogger _logger;
    private readonly IParkRepository _repository;


    public ParkController(IParkRepository repository, IMapper mapper,
      IHttpClientFactory client, ILogger<ParkController> logger)
    {
      _repository = repository ?? throw new ArgumentNullException(nameof(repository));
      _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
      _client = client ?? throw new ArgumentNullException(nameof(client));
      _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    /// <summary>
    /// Getting all parks
    /// </summary>
    /// <returns></returns>
    [HttpGet("getparks")]
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
        _logger.LogError($"Something went wrong in the {nameof(GetParks)} action {e}");
        return StatusCode(500, "Internal server error");
      }

    }

    /// <summary>
    /// Get one band
    /// </summary>
    /// <param name="parkId"></param>
    /// <returns></returns>
    [HttpGet("getpark", Name = "GetPark")]
    [ResponseCache(Duration = 60)]
    public async Task<ActionResult<Parky>> GetPark([FromQuery]Guid parkId)
    {
      try
      {
        var parkFromRepo = await _repository.GetPark(parkId);
        return Ok(parkFromRepo);
        
      }
      catch (Exception e)
      {
        _logger.LogError($"Could not find the {parkId} action {e}");
        return StatusCode(500, "something went wrong");
      }

    }

    /// <summary>
    /// Create a new park
    /// </summary>
    /// <param name="park"></param>
    [HttpPost("createpark")]
    [ResponseCache(Duration = 60)]
    public async Task<IActionResult> CreatePark(Parky park)
    {
      // TODO rewrite using DTOs
      await _repository.CreatePark(park);
      _repository.Save();

      return Created("GetPark", park);
    }

    /// <summary>
    /// Update a park
    /// </summary>
    /// <param name="park"></param>
    /// <returns></returns>
    [HttpPut("updatepark")]
    [ResponseCache(Duration = 60)]
    public async Task<IActionResult> UpdatePark(Parky park)
    {
      try
      {
        _repository.UpdatePark(park);
        _repository.Save();

        return Ok(park);
      }
      catch (Exception e)
      {
        _logger.LogError($"Could not find an element to update");
        return StatusCode(500, "Something went wrong");
      }


      
    }

    /// <summary>
    /// Delete a park
    /// </summary>
    /// <param name="parkId"></param>
    /// <returns></returns>
    [HttpDelete]
    [Route("deletepark")]
    [ResponseCache(Duration = 60)]
    public ActionResult DeletePark([FromQuery]Guid parkId)
    {
      _repository.DeletePark(parkId);
      _repository.Save();

      return Ok(parkId);

    }

  }
}


