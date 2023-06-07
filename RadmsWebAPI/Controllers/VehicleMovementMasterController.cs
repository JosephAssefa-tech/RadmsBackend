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
    public class VehicleMovementMasterController : ControllerBase
    {
        public IVechileMovementService _service;
        public VehicleMovementMasterController(IVechileMovementService service)
        {
            _service = service;

        }

        // GET: api/<VehicleMovementMasterController>
        [HttpGet]
        public List<VehicleMovementMasterViewModel> GetAll(string? language)
        {
            List<VehicleMovementMasterEntity> entities = this._service.GetAll(language);
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
        public void Save([FromBody] VehicleMovementMasterPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<VehicleMovementMasterEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }
        }

        // PUT api/<VehicleMovementMasterController>/5
        [HttpPut]
        public void Update([FromBody] VehicleMovementMasterPutModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<VehicleMovementMasterEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<VehicleMovementMasterController>/5
        [HttpDelete]
        public void Delete(int vehicleMovementId)
        {
            var result = this._service.Delete(vehicleMovementId);
        }
    }
}
