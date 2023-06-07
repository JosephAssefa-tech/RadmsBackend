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
    public class LightConditionController : ControllerBase
    {
        public IlightConditionService _service;
        public LightConditionController(IlightConditionService service)
        {
            _service = service;
        }

            // GET: api/<LightConditionController>
            [HttpGet]
        public List<LightConditionLookupViewModel> GetAll(string language)
        {
            List<LightConditionLookupEntity> entities = this._service.GetAll(language);
            List<LightConditionLookupViewModel> viewModels = new List<LightConditionLookupViewModel>();
            foreach (var entity in entities)
            {
                LightConditionLookupViewModel model = new LightConditionLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<LightConditionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LightConditionController>
        [HttpPost]
        public void Save([FromBody] LightConditionLookupPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<LightConditionLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }
        }

        // PUT api/<LightConditionController>/5
        [HttpPut]
        public void Update(LightConditionLookupPutModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<LightConditionLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<LightConditionController>/5
        [HttpDelete]
        public void Delete(int lightConditionId)
        {
            var result = this._service.Delete(lightConditionId);
        }
    }
}
