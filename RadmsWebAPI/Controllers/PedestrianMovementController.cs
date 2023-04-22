using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedestrianMovementController : ControllerBase
    {
        IPedestrianMovementLookupService _service;
        public PedestrianMovementController(IPedestrianMovementLookupService service)
        {
            _service = service;
        }


        // GET: api/<PedestrianMovementController>
        [HttpGet]
        public List<PedestrianMovementLookupViewModel> GetAll()
        {
            List<PedestrianMovementLookupEntity> entities = this._service.GetAll();
            List<PedestrianMovementLookupViewModel> viewModels = new List<PedestrianMovementLookupViewModel>();
            foreach (var entity in entities)
            {
                PedestrianMovementLookupViewModel model = new PedestrianMovementLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<PedestrianMovementController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PedestrianMovementController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PedestrianMovementController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PedestrianMovementController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
