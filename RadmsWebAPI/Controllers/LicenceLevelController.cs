using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
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
        public List<LicenceLevelLookupViewModel> GetAll()
        {
            List<LicenceLevelLookupEntity> entities = this._service.GetAll();
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
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LicenceLevelController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LicenceLevelController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
