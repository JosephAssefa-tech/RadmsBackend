using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleMovementMasterController : ControllerBase
    {
        public IVechileMovementService _service;
        public VehicleMovementMasterController(IVechileMovementService service)
        {
            _service = service;

        }

        // GET: api/<VehicleMovementMasterController>
        [HttpGet]
        public List<VehicleMovementMasterViewModel> GetAll()
        {
            List<VehicleMovementMasterEntity> entities = this._service.GetAll();
            List<VehicleMovementMasterViewModel> viewModels = new List<VehicleMovementMasterViewModel>();
            foreach (var entity in entities)
            {
                VehicleMovementMasterViewModel model = new VehicleMovementMasterViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<VehicleMovementMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VehicleMovementMasterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VehicleMovementMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VehicleMovementMasterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
