using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthConditionController : ControllerBase
    {
        IHealthConditionLookupService _service;
            public HealthConditionController(IHealthConditionLookupService service)
        {
            _service = service;

        }
        // GET: api/<HealthConditionController>
        [HttpGet]
        public List<HealthConditionLookupViewModel> GetAll()
        {
            List<HealthConditionLookupEntity> entities = this._service.GetAll();
            List<HealthConditionLookupViewModel> viewModels = new List<HealthConditionLookupViewModel>();
            foreach (var entity in entities)
            {
                HealthConditionLookupViewModel model = new HealthConditionLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<HealthConditionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HealthConditionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HealthConditionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HealthConditionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
