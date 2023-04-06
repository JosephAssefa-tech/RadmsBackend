using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverExperienceController : ControllerBase
    {
        public IDriverExperienceLookupService _service;
        public DriverExperienceController(IDriverExperienceLookupService service)
        {
            this._service = service;
        }
        // GET: api/<DriverExperienceController>
        [HttpGet]
        public List<DriverExperienceLookupViewModel> GetAll()
        {
            List<DriverExperienceLookupEntity> entities = this._service.GetAll();
            List<DriverExperienceLookupViewModel> viewModels = new List<DriverExperienceLookupViewModel>();
            foreach (var entity in entities)
            {
                DriverExperienceLookupViewModel model = new DriverExperienceLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<DriverExperienceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DriverExperienceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DriverExperienceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DriverExperienceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
