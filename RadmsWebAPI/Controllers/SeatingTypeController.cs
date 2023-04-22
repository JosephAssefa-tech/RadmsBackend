using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatingTypeController : ControllerBase
    {
        ISeatingTypeServicecs _service;
        public SeatingTypeController(ISeatingTypeServicecs service)
        {
            _service = service;

        }
        // GET: api/<SeatingTypeController>
        [HttpGet]
        public List<SeatingTypeLookupViewModel> GetAll()
        {
            List<SeatingTypeLookupEntity> entities = this._service.GetAll();
            List<SeatingTypeLookupViewModel> viewModels = new List<SeatingTypeLookupViewModel>();
            foreach (var entity in entities)
            {
                SeatingTypeLookupViewModel model = new SeatingTypeLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<SeatingTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SeatingTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SeatingTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SeatingTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
