using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.PostModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoadsInvolvedDetailsTransactionController : ControllerBase
    {
        IRoadsInvolvedDetailsTransactionService _service;
        public RoadsInvolvedDetailsTransactionController(IRoadsInvolvedDetailsTransactionService service)
        {
            _service = service;

        }
        // GET: api/<RoadsInvolvedDetailsTransactionController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<RoadsInvolvedDetailsTransactionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RoadsInvolvedDetailsTransactionController>
        [HttpPost]
        public void Save([FromBody] RoadsInvolvedDetailsTransactionPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<RoadsInvolvedDetailsTransactionEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }
        }

        // PUT api/<RoadsInvolvedDetailsTransactionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RoadsInvolvedDetailsTransactionController>/5
        [HttpDelete]
        public void Delete(int regionId)
        {
            var result = this._service.Delete(regionId);
        }
    }
}
