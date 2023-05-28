using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KebeleMasterController : ControllerBase
    {
        // GET: api/<KebeleMasterController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<KebeleMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<KebeleMasterController>
        //[HttpPost]
        //public void Post([FromBody] KebeleMasterPostModel postModel)
        //{
        //    string result = this._service.Save(postModel.MapToViewEntity<ZoneMasterEntity>());
        //    if (result == "saved sucessfuly")
        //    {

        //    }
        //    else
        //    {

        //    }
        //}

        // PUT api/<KebeleMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<KebeleMasterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
