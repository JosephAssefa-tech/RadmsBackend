using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleDefectController : ControllerBase
    {
        public IVehicleDefectService _service;
        public VehicleDefectController(IVehicleDefectService service)
        {
            _service= service;
        }

        // GET: api/<VehicleDefectController>
        [HttpGet]
        public List<VehicleDefectLookupViewModel> GetAll()
        {
            List<VehicleDefectLookupEntity> entities = this._service.GetAll();
            List<VehicleDefectLookupViewModel> viewModels = new List<VehicleDefectLookupViewModel>();
            foreach (var entity in entities)
            {
                VehicleDefectLookupViewModel model = new VehicleDefectLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<VehicleDefectController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VehicleDefectController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VehicleDefectController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VehicleDefectController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
