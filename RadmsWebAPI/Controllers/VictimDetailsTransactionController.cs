using Microsoft.AspNetCore.Mvc;
using RadmsDataModels.Modelss;
using RadmsEntities;
using RadmsRepositoryManager.Services;
using RadmsServiceFacade;
using RadmsWebAPI.Models.PostModels;
using RadmsWebAPI.Response;
using Newtonsoft.Json;
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
        public async Task<ActionResult<IEnumerable<SummaryData>>> GetGroupedData(DateTime? startDate, DateTime? endDate)
        {
            
                var groupedData = await _service.GetGroupedDataAsync(startDate, endDate);
                return Ok(groupedData);
            

        }
        [HttpGet("grouped-region-data")]

        public ActionResult<List<SummaryData>> GetSummaryWithDateAndRegion(int? regionId,DateTime? dateTime)
        {
          //  AccidentDetailsTransactionEntity entity = new AccidentDetailsTransactionEntity();
            var groupedData =  _service.GetSummaryWithDateAndRegion(regionId,dateTime);
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
        [HttpGet("trend-analysis-data")]
        public async Task<IActionResult> GetTrendAnalysisData()
        {
            int currentYear = DateTime.Now.Year;
            var data = new List<object>();

            for (int i = 0; i < 11; i++)
            {
                int year = currentYear - i;
                var fatalCount = await this._service.GetFatalAccidentCount(year);
                var seriousCount = await this._service.GetSeriousAccidentCount(year);
                var slightCount = await this._service.GetSlightAccidentCount(year);
                var propertyDamageCount = await this._service.GetPropertyDamageCount(year);

                var yearData = new TrendAnalysisResponse()
                {
                    Year = year,
                    FatalCount = fatalCount,
                    SeriousCount = seriousCount,
                    SlightCount = slightCount,
                    PropertyDamageCount = propertyDamageCount
                };

                data.Add(yearData);
            }

            return Ok(data);
        }
    }
}
