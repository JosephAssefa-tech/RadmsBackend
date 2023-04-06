using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleServiceAgeController : ControllerBase
    {
       public IVechileServiceAgeService _service;
        public VehicleServiceAgeController(IVechileServiceAgeService service)
        {
            _service = service;
        }

        // GET: api/<VehicleServiceAgeController>
        [HttpGet]
        public List<VehicleServiceAgeLookupViewModel> GetAll()
        {
            List<VehicleServiceAgeLookupEntity> entities = this._service.GetAll();
            List<VehicleServiceAgeLookupViewModel> viewModels = new List<VehicleServiceAgeLookupViewModel>();
            foreach (var entity in entities)
            {
                VehicleServiceAgeLookupViewModel model = new VehicleServiceAgeLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<VehicleServiceAgeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VehicleServiceAgeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VehicleServiceAgeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VehicleServiceAgeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
