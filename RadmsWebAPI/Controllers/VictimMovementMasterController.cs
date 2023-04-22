using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VictimMovementMasterController : ControllerBase
    {
        IVictimMovementMasterService _service;
        public VictimMovementMasterController(IVictimMovementMasterService service)
        {
            _service = service;

        }
        // GET: api/<VictimMovementMasterController>
        [HttpGet]
        public List<VictimMovementMasterViewModel> GetAll()
        {
            List<VictimMovementMasterEntity> entities = this._service.GetAll();
            List<VictimMovementMasterViewModel> viewModels = new List<VictimMovementMasterViewModel>();
            foreach (var entity in entities)
            {
                VictimMovementMasterViewModel model = new VictimMovementMasterViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<VictimMovementMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VictimMovementMasterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VictimMovementMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VictimMovementMasterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
