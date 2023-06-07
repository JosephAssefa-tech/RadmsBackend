using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleRelationController : ControllerBase
    {
        public IVehicleRelationLookupService _service;
        public VehicleRelationController(IVehicleRelationLookupService service)
        {
            _service = service;
        }


        // GET: api/<VehicleRelationController>
        [HttpGet]
        public List<VehicleRelationLookupViewModel> GetAll(string? language)
        {
            List<VehicleRelationLookupEntity> entities = this._service.GetAll(language);
            List<VehicleRelationLookupViewModel> viewModels = new List<VehicleRelationLookupViewModel>();
            foreach (var entity in entities)
            {
                VehicleRelationLookupViewModel model = new VehicleRelationLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<VehicleRelationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VehicleRelationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VehicleRelationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VehicleRelationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
