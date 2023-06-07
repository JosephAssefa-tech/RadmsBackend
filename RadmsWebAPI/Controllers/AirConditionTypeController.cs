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
    public class AirConditionTypeController : ControllerBase
    {
        public IAirConditionTypeService _service;
        public AirConditionTypeController(IAirConditionTypeService service)
        {
            this._service = service;
        }
        // GET: api/<AirConditionTypeController>
        [HttpGet]
        public List<AirConditionTypeLookupViewModel> GetAll(string language)
        {
            List<AirConditionTypeLookupEntity> entities = this._service.GetAll(language);
            List<AirConditionTypeLookupViewModel> viewModels = new List<AirConditionTypeLookupViewModel>();
            foreach (var entity in entities)
            {
                AirConditionTypeLookupViewModel model = new AirConditionTypeLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<AirConditionTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AirConditionTypeController>
        [HttpPost]
        public void Save([FromBody] AirConditionTypeLookupPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<AirConditionTypeLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }
        }

        // PUT api/<AirConditionTypeController>/5
        [HttpPut]
        public void UPdate(AirConditionTypeLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<AirConditionTypeLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<AirConditionTypeController>/5
        [HttpDelete]
        public void Delete(int airConditionId)
        {
            var result = this._service.Delete(airConditionId);
        }
    }
}
