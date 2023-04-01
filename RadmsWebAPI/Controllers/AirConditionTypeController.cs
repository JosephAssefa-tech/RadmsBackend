using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirConditionTypeController : ControllerBase
    {
        public IAirConditionTypeService _service;
        public AirConditionTypeController(IAirConditionTypeService service)
        {
            this._service = service;
        }
        // GET: api/<AirConditionTypeController>
        [HttpGet]
        public List<AirConditionTypeLookupViewModel> GetAll()
        {
            List<AirConditionTypeLookupEntity> entities = this._service.GetAll();
            List<AirConditionTypeLookupViewModel> viewModels = new List<AirConditionTypeLookupViewModel>();
            foreach (var entity in entities)
            {
                AirConditionTypeLookupViewModel model = new AirConditionTypeLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<AirConditionTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AirConditionTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AirConditionTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AirConditionTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
