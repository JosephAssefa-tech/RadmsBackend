using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LightConditionController : ControllerBase
    {
        public IlightConditionService _service;
        public LightConditionController(IlightConditionService service)
        {
            _service = service;
        }

            // GET: api/<LightConditionController>
            [HttpGet]
        public List<LightConditionLookupViewModel> GetAll()
        {
            List<LightConditionLookupEntity> entities = this._service.GetAll();
            List<LightConditionLookupViewModel> viewModels = new List<LightConditionLookupViewModel>();
            foreach (var entity in entities)
            {
                LightConditionLookupViewModel model = new LightConditionLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<LightConditionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LightConditionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LightConditionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LightConditionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
