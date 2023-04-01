using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandmarkTypeController : ControllerBase
    {
        public ILandmarkTypeService _service;
        public LandmarkTypeController(ILandmarkTypeService service)
        {
            _service = service;
        }
        // GET: api/<LandmarkTypeController>
        [HttpGet]
        public List<LandmarkTypeLookupViewModel> GetAll()
        {
            List<LandmarkTypeLookupEntity> entities = this._service.GetAll();
            List<LandmarkTypeLookupViewModel> viewModels = new List<LandmarkTypeLookupViewModel>();
            foreach (var entity in entities)
            {
                LandmarkTypeLookupViewModel model = new LandmarkTypeLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<LandmarkTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LandmarkTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LandmarkTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LandmarkTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
