﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImpactTypeController : ControllerBase
    {
        // GET: api/<ImpactTypeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ImpactTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ImpactTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ImpactTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ImpactTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
