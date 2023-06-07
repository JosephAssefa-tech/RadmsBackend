using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.PostModels;
using RadmsWebAPI.Models.PutModels;
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
        public List<VehicleDefectLookupViewModel> GetAll(string? language)
        {
            List<VehicleDefectLookupEntity> entities = this._service.GetAll(language);
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
        public void Save([FromBody] VehicleDefectLookupPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<VehicleDefectLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }
        }

        // PUT api/<VehicleDefectController>/5
        [HttpPut]
        public void Update([FromBody] VehicleDefectLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<VehicleDefectLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<VehicleDefectController>/5
        // DELETE api/<VechicleMasterController>/5
        [HttpDelete]
        public void Delete(int vehicleDefectId)
        {
            var result = this._service.Delete(vehicleDefectId);
        }
    }
}
