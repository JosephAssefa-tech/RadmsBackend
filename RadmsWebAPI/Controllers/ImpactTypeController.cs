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
    public class ImpactTypeController : ControllerBase
    {
        IImpactTypeService _service;
        public ImpactTypeController(IImpactTypeService service)
        {
            _service = service;

        }
        // GET: api/<ImpactTypeController>
        [HttpGet]
        public List<ImpactTypeLookupViewModel> GetAll(string? language)
        {
            List<ImpactTypeLookupEntity> entities = this._service.GetAll(language);
            List<ImpactTypeLookupViewModel> viewModels = new List<ImpactTypeLookupViewModel>();
            foreach (var entity in entities)
            {
                ImpactTypeLookupViewModel model = new ImpactTypeLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<ImpactTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ImpactTypeController>
        [HttpPost]
        public void Save([FromBody] ImpactTypeLookupPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<ImpactTypeLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        // PUT api/<ImpactTypeController>/5
        [HttpPut]
        public void Update([FromBody] ImpactTypeLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<ImpactTypeLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<ImpactTypeController>/5
        [HttpDelete]
        public void Delete(int impactTypeId)
        {
            var result = this._service.Delete(impactTypeId);
        }
    }
}
