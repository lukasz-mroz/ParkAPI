﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
      _park = park;
      _mapper = mapper;
    }

    /// <summary>
    /// Getting all bands from repositories
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("getband")]
    public IActionResult GetBands()
    {
      var allBands = _park.GetBand();

      return Ok(allBands);
    }

    
  }
}

