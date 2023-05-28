using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeedLimitController : ControllerBase
    {
        ISpeedLimitService _service;
        public SpeedLimitController(ISpeedLimitService service)
        {
            _service = service;
        }
        // GET: api/<SpeedLimitController>
        [HttpGet]
        public List<SpeedLimitLookupViewModel> GetAll(string language)
        {
            List<SpeedLimitLookupEntity> entities = this._service.GetAll(language);
            List<SpeedLimitLookupViewModel> viewModels = new List<SpeedLimitLookupViewModel>();
            foreach (var entity in entities)
            {
                SpeedLimitLookupViewModel model = new SpeedLimitLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<SpeedLimitController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SpeedLimitController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SpeedLimitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SpeedLimitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
