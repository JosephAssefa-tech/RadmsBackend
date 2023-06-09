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
    public class LicenceLevelController : ControllerBase
    {
        ILicenceLevelLookupService _service;
        public LicenceLevelController(ILicenceLevelLookupService service)
        {
            this._service = service;
        }
        // GET: api/<LicenceLevelController>
        [HttpGet]
        public List<LicenceLevelLookupViewModel> GetAll(string? language)
        {
            List<LicenceLevelLookupEntity> entities = this._service.GetAll(language);
            List<LicenceLevelLookupViewModel> viewModels = new List<LicenceLevelLookupViewModel>();
            foreach (var entity in entities)
            {
                LicenceLevelLookupViewModel model = new LicenceLevelLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<LicenceLevelController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LicenceLevelController>
        [HttpPost]
        public void Save([FromBody] LicenceLevelLookupPostModel viewModel)
        {
            string result = this._service.Save(viewModel.MapToViewEntity<LicenceLevelLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }

        }

        // PUT api/<LicenceLevelController>/5
        [HttpPut]
        public void Update([FromBody] LicenceLevelLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<LicenceLevelLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<LicenceLevelController>/5
        [HttpDelete]
        public void Delete(int leveloflicenceId)
        {
            var result = this._service.Delete(leveloflicenceId);
        }
    }
}
