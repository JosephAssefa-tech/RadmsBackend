using Microsoft.AspNetCore.Mvc;
using RadmsDataModels.Models;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.PostModels;
using RadmsWebAPI.Response;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
 
    [Route("api/[controller]")]
    [ApiController]
    public class VictimDetailsTransactionController : ControllerBase
    {
        IVictimDetailTransaction _service;
        public VictimDetailsTransactionController(IVictimDetailTransaction service)
        {
            _service = service;

        }
        // GET: api/<VictimDetailsTransactionController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet("grouped-data")]
        public async Task<ActionResult<IEnumerable<SummaryData>>> GetGroupedData()
        {
            
                var groupedData = await _service.GetGroupedDataAsync();
                return Ok(groupedData);
            

        }



        // GET api/<VictimDetailsTransactionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VictimDetailsTransactionController>
        [HttpPost]
        public void Save([FromBody] VictimDetailsTransactionPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<VictimDetailsTransactionEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }
        }

        // PUT api/<VictimDetailsTransactionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VictimDetailsTransactionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
