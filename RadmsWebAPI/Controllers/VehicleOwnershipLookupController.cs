using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.PutModels;
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
        public List<VehicleOwnershipLookupViewModel> GetAll(string? language)
        {
            List<VehicleOwnershipLookupEntity> entities = this._service.GetAll(language);
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
        public void Post([FromBody] VehicleOwnershipLookupUpdateModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<VehicleOwnershipLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }
        }

        // PUT api/<VehicleOwnershipLookupController>/5
        [HttpPut]
        public void Put([FromBody] VehicleOwnershipLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<VehicleOwnershipLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<VehicleOwnershipLookupController>/5
        [HttpDelete]
        public void Delete(int vehicleOwnershipId)
        {
            var result = this._service.Delete(vehicleOwnershipId);
        }
    }
}
