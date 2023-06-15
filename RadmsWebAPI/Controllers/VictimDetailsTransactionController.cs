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

        public ActionResult<List<SummaryData>> GetSummaryWithDateAndRegion(int? regionId, DateTime? startDate, DateTime? endDate)
        {
          //  AccidentDetailsTransactionEntity entity = new AccidentDetailsTransactionEntity();
            var groupedData =  _service.GetSummaryWithDateAndRegion(regionId, startDate, endDate);
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
        //[HttpGet("trend-analysis-data")]
        //public async Task<IActionResult> GetTrendAnalysisData(DateTime? startDate,DateTime? endDate)
        //{
        //    int currentYear = DateTime.Now.Year;
        //    var data = new List<object>();

        //    for (int i = 0; i < 11; i++)
        //    {
        //        int year = currentYear - i;
        //        var fatalCount = await this._service.GetFatalAccidentCount(year, startDate, endDate);
        //        var seriousCount = await this._service.GetSeriousAccidentCount(year, startDate, endDate);
        //        var slightCount = await this._service.GetSlightAccidentCount(year, startDate, endDate);
        //        var propertyDamageCount = await this._service.GetPropertyDamageCount(year, startDate, endDate);

        //        var yearData = new TrendAnalysisResponse()
        //        {
        //            Year = year,
        //            FatalCount = fatalCount,
        //            SeriousCount = seriousCount,
        //            SlightCount = slightCount,
        //            PropertyDamageCount = propertyDamageCount
        //        };

        //        data.Add(yearData);
        //    }

        //    return Ok(data);
        //}
        [HttpGet("trend-analysis-data")]
        public async Task<IActionResult> GetTrendAnalysisData(DateTime? startDate, DateTime? endDate)
        {
            int currentYear = DateTime.Now.Year;
            var data = new List<object>();

            if (!startDate.HasValue && !endDate.HasValue)
            {
                // User didn't select startDate and endDate filter
                for (int i = 0; i < 10; i++)
                {
                    int year = currentYear - i;
                    var yearData = await GetYearData(year, startDate, endDate);
                    data.Add(yearData);
                }
            }
            else if (startDate.HasValue && endDate.HasValue)
            {
                // User selected startDate and endDate filter
                for (DateTime date = startDate.Value; date <= endDate.Value; date = date.AddYears(1))
                {
                    var yearData = await GetYearData(date.Year, startDate, endDate);
                    data.Add(yearData);
                }
            }
            else
            {
                // Handle other scenarios if needed
            }

            return Ok(data);
        }

        private async Task<TrendAnalysisResponse> GetYearData(int year, DateTime? startDate, DateTime? endDate)
        {
            var fatalCount = await this._service.GetFatalAccidentCount(year, startDate, endDate);
            var seriousCount = await this._service.GetSeriousAccidentCount(year, startDate, endDate);
            var slightCount = await this._service.GetSlightAccidentCount(year, startDate, endDate);
            var propertyDamageCount = await this._service.GetPropertyDamageCount(year, startDate, endDate);

            var yearData = new TrendAnalysisResponse()
            {
                Year = year,
                FatalCount = fatalCount,
                SeriousCount = seriousCount,
                SlightCount = slightCount,
                PropertyDamageCount = propertyDamageCount
            };

            return yearData;
        }

    }
}
