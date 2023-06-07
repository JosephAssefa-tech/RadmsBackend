using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsRepositoryFacade;
using RadmsWebAPI.Models.PostModels;
using RadmsWebAPI.Models.PutModels;
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
        public List<VehicleServiceAgeLookupViewModel> GetAll(string? language)
        {
            List<VehicleServiceAgeLookupEntity> entities = this._service.GetAll(language);
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
        public void Save([FromBody] VehicleServiceAgeLookupPostModel postModel)
        {
            string result = this._service.Save(postModel.MapToViewEntity<VehicleServiceAgeLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        // PUT api/<VehicleServiceAgeController>/5
        [HttpPut]
        public void Update([FromBody] VehicleServiceAgeLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<VehicleServiceAgeLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<VehicleServiceAgeController>/5
        [HttpDelete]
        public void Delete(int vehicleServiceAgeId)
        {
            var result = this._service.Delete(vehicleServiceAgeId);
        }
    }
}
