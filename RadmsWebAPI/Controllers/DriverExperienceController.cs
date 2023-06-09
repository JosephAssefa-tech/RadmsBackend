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
    public class DriverExperienceController : ControllerBase
    {
        public IDriverExperienceLookupService _service;
        public DriverExperienceController(IDriverExperienceLookupService service)
        {
            this._service = service;
        }
        // GET: api/<DriverExperienceController>
        [HttpGet]
        public List<DriverExperienceLookupViewModel> GetAll(string? language)
        {
            List<DriverExperienceLookupEntity> entities = this._service.GetAll(language);
            List<DriverExperienceLookupViewModel> viewModels = new List<DriverExperienceLookupViewModel>();
            foreach (var entity in entities)
            {
                DriverExperienceLookupViewModel model = new DriverExperienceLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<DriverExperienceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DriverExperienceController>
        [HttpPost]
        public void Save([FromBody] DriverExperienceLookupPostModel postModel)
        {
            string result = this._service.Save(postModel.MapToViewEntity<DriverExperienceLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }
        }

        // PUT api/<DriverExperienceController>/5
        [HttpPut]
        public void Update([FromBody] DriverExperienceLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<DriverExperienceLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<DriverExperienceController>/5
        [HttpDelete]
        public void Delete(int driverExperienceId)
        {
            var result = this._service.Delete(driverExperienceId);
        }
    }
}
