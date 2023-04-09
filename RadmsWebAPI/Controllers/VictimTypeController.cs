using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VictimTypeController : ControllerBase
    {
        IVictimTypeLookupService _service;
        public VictimTypeController(IVictimTypeLookupService service)
        {
            _service = service; 

        }
        // GET: api/<VictimTypeController>
        [HttpGet]
        public List<VictimTypeLookupViewModel> GetAll()
        {
            List<VictimTypeLookupEntity> entities = this._service.GetAll();
            List<VictimTypeLookupViewModel> viewModels = new List<VictimTypeLookupViewModel>();
            foreach (var entity in entities)
            {
                VictimTypeLookupViewModel model = new VictimTypeLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<VictimTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VictimTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VictimTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VictimTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
