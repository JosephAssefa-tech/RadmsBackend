using Microsoft.AspNetCore.Mvc;
using RadmsEntities;
using RadmsServiceFacade;
using RadmsWebAPI.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadmsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrivingLicenceCatagoryController : ControllerBase
    {
        IDrivingLicenceCatagoryLookupService _service;
        public DrivingLicenceCatagoryController(IDrivingLicenceCatagoryLookupService service)
        {
            _service = service;

        }
        // GET: api/<DrivingLicenceCatagoryController>
        [HttpGet]
        public List<DrivingLicenceCatagoryLookupViewModel> GetAll()
        {
            List<DrivingLicenceCatagoryLookupEntity> entities = this._service.GetAll();
            List<DrivingLicenceCatagoryLookupViewModel> viewModels = new List<DrivingLicenceCatagoryLookupViewModel>();
            foreach (var entity in entities)
            {
                DrivingLicenceCatagoryLookupViewModel model = new DrivingLicenceCatagoryLookupViewModel(entity);
                viewModels.Add(model);
            }
            return viewModels;
        }

        // GET api/<DrivingLicenceCatagoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DrivingLicenceCatagoryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DrivingLicenceCatagoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DrivingLicenceCatagoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
