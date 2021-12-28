﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SampleUntiTestingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id < 1)
                return BadRequest($"Invalid request for id {id}");

            return id.ToString();
        }

        [HttpPost]
        public ActionResult Post()
        {
            return Ok("batch job started");
        }
    }
}