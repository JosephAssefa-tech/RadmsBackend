using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;
using RadmsWebAPI.Response;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlackSpotController : ControllerBase
    {
        IBlackSpotService _service;
        public BlackSpotController(IBlackSpotService service)
        {
            this._service = service;
        }
        // GET: api/<BlackSpotController>
        [HttpGet]
        public List<BlackSpotMasterViewModel> GetAll(DateTime? startDate, DateTime? endDate)
        {
            List<BlackSpotMasterEntity> entities = this._service.GetAll(startDate,endDate);
            List<BlackSpotMasterViewModel> viewModels = new List<BlackSpotMasterViewModel>();
            foreach (var entity in entities)
            {
                BlackSpotMasterViewModel model = new BlackSpotMasterViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }
        [HttpGet("count-blackspot")]
        public IActionResult GetTotalNumberOfBlackspotCount()
        {
            ResponseDtos response = new ResponseDtos();
            int blackspotCount = this._service.GetTotalBlackspotCount();
            if (blackspotCount == 0)
            {
                response.StatusCode = 404;
                response.Message = "no record is found";
                return NotFound();

            }
            else
            {
                response.StatusCode = 200;
                response.Message = "Success";
                var dashboardResponse = new DashboardResponse
                {
                    blackspotCount = blackspotCount
                };
                return Ok(dashboardResponse);

            }
        }

        // GET api/<BlackSpotController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BlackSpotController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BlackSpotController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BlackSpotController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
