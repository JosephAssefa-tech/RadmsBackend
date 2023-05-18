using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoadSurfaceConditionLookupController : ControllerBase
    {
        IRoadSurfaceConditionService _service;
        public RoadSurfaceConditionLookupController(IRoadSurfaceConditionService service)
        {
            _service = service;
        }

        // GET: api/<RoadSurfaceConditionLookupController>
        [HttpGet]
        public List<RoadSurfaceConditionLookupViewModel> GetAll(string language)
        {
            List<RoadSurfaceConditionLookupEntity> entities = this._service.GetAll(language);
            List<RoadSurfaceConditionLookupViewModel> viewModels = new List<RoadSurfaceConditionLookupViewModel>();
            foreach (var entity in entities)
            {
                RoadSurfaceConditionLookupViewModel model = new RoadSurfaceConditionLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<RoadSurfaceConditionLookupController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RoadSurfaceConditionLookupController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RoadSurfaceConditionLookupController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RoadSurfaceConditionLookupController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
