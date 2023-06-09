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
    public class DrivingLicenceCatagoryController : ControllerBase
    {
        IDrivingLicenceCatagoryLookupService _service;
        public DrivingLicenceCatagoryController(IDrivingLicenceCatagoryLookupService service)
        {
            _service = service;

        }
        // GET: api/<DrivingLicenceCatagoryController>
        [HttpGet]
        public List<DrivingLicenceCatagoryLookupViewModel> GetAll(string? language)
        {
            List<DrivingLicenceCatagoryLookupEntity> entities = this._service.GetAll(language);
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
        [HttpPost]
        public void Save([FromBody] DrivingLicenceCatagoryLookupPostModel postModel)
        {
            string result = this._service.Save(postModel.MapToViewEntity<DrivingLicenceCatagoryLookupEntity>());
            if (result == "saved sucessfuly")
            {

            }
            else
            {

            }
        }

        // POST api/<DrivingLicenceCatagoryController>


        // PUT api/<DrivingLicenceCatagoryController>/5
        [HttpPut]
        public void Update([FromBody] DriverExperienceLookupUpdateModel viewModel)
        {
            string result = this._service.Update(viewModel.MapToViewEntity<DrivingLicenceCatagoryLookupEntity>());
            if (result == "Updated sucessfuly")
            {

            }
            else
            {

            }
        }

        // DELETE api/<DrivingLicenceCatagoryController>/5
        [HttpDelete]
        public void Delete(int drivingLicenceCatagoryId)
        {
            var result = this._service.Delete(drivingLicenceCatagoryId);
        }
    }
}
