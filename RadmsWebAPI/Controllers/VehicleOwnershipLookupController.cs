using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleOwnershipLookupController : ControllerBase
    {
        public IVehicleOwnershipService _service;
        public VehicleOwnershipLookupController(IVehicleOwnershipService service)
        {
            this._service = service;
        }
        // GET: api/<VehicleOwnershipLookupController>
        [HttpGet]
        public List<VehicleOwnershipLookupViewModel> GetAll()
        {
            List<VehicleOwnershipLookupEntity> entities = this._service.GetAll();
            List<VehicleOwnershipLookupViewModel> viewModels = new List<VehicleOwnershipLookupViewModel>();
            foreach (var entity in entities)
            {
                VehicleOwnershipLookupViewModel model = new VehicleOwnershipLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<VehicleOwnershipLookupController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VehicleOwnershipLookupController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VehicleOwnershipLookupController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VehicleOwnershipLookupController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
