using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoadCarriagewayTypeController : ControllerBase
    {
        IRoadCarriagewayTypeService _service;
        public RoadCarriagewayTypeController(IRoadCarriagewayTypeService service)
        {
            _service = service;
        }

        // GET: api/<RoadCarriagewayTypeController>
        [HttpGet]
        public List<RoadCarriagewayTypeLookupViewModel> GetAll(string language)
        {
            List<RoadCarriagewayTypeLookupEntity> entities = this._service.GetAll(language);
            List<RoadCarriagewayTypeLookupViewModel> viewModels = new List<RoadCarriagewayTypeLookupViewModel>();
            foreach (var entity in entities)
            {
                RoadCarriagewayTypeLookupViewModel model = new RoadCarriagewayTypeLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<RoadCarriagewayTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RoadCarriagewayTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RoadCarriagewayTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RoadCarriagewayTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
