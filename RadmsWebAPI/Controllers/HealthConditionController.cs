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
    public class HealthConditionController : ControllerBase
    {
        IHealthConditionLookupService _service;
            public HealthConditionController(IHealthConditionLookupService service)
        {
            _service = service;

        }
        // GET: api/<HealthConditionController>
        [HttpGet]
        public List<HealthConditionLookupViewModel> GetAll(string? language)
        {
            List<HealthConditionLookupEntity> entities = this._service.GetAll(language);
            List<HealthConditionLookupViewModel> viewModels = new List<HealthConditionLookupViewModel>();
            foreach (var entity in entities)
            {
                HealthConditionLookupViewModel model = new HealthConditionLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<HealthConditionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HealthConditionController>
        [HttpPost]
        public void Save([FromBody] HealthConditionLookupPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<HealthConditionLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }
        }

        // PUT api/<HealthConditionController>/5

        [HttpPut]
        public void Update([FromBody] HealthConditionLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<HealthConditionLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<HealthConditionController>/5
        [HttpDelete]
        public void Delete(int healthConditionId)
        {
            var result = this._service.Delete(healthConditionId);
        }
    }
}
