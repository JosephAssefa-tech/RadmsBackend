using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.PostModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LegalMeasurementDetailsTransactionController : ControllerBase
    {
        ILegalMeasurementDetailsTransaction _service;
        public LegalMeasurementDetailsTransactionController(ILegalMeasurementDetailsTransaction service)
        {
            _service = service;

        }
        // GET: api/<LegalMeasurementDetailsTransactionController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LegalMeasurementDetailsTransactionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LegalMeasurementDetailsTransactionController>
        [HttpPost]
        public void Save([FromBody] LegalMeasurementDetailsTransactionPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<LegalMeasurementDetailsTransactionEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }
        }

        // PUT api/<LegalMeasurementDetailsTransactionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LegalMeasurementDetailsTransactionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
